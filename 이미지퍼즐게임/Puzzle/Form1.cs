using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        int[,] PuzzleTable;     // 퍼즐상태 확인용 퍼즐 테이블
        Button[] btn;           // 퍼즐 버튼 배열 변수
        Image[] piece_image;    // 조각 이미지 배열 변수

        int ROW, COL, NUM = 0;  // 숨긴 퍼즐의 위치, 번호

        int num_of_puzzle;      // 퍼즐 개수
        int puzzle_row_col;     // 퍼즐 가로세로 개수
        int btn_size;           // 퍼즐 버튼 크기 (가로세로)

        Image img = new Bitmap(Properties.Resources._1);    // 사진 불러오기
        Size resize = new Size(200, 200);
        Stopwatch timer = new Stopwatch();
        DialogResult YesOrNo = new DialogResult();

        public Form1()
        {
            InitializeComponent();
        }

        private void start44btn_Click(object sender, EventArgs e)
        {
            if (time_label.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("현재 게임을 끝내시겠습니까 ?", "4 x 4 퍼즐", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || time_label.Text == "00:00:00")
            {
                foreach (Button btn in panel1.Controls)
                {
                    btn.Visible = false;
                }
                num_of_puzzle = 16;
                puzzle_row_col = 4;
                btn_size = 60;

                createButton();

                timer.Reset();
                time_label.Text = "00:00:00";
            }
        }

        private void start33btn_Click(object sender, EventArgs e)
        {
            if (time_label.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("현재 게임을 끝내시겠습니까 ?", "3 x 3 퍼즐", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || time_label.Text == "00:00:00")
            {
                foreach (Button btn in panel1.Controls)
                {
                    btn.Visible = false;
                }
                num_of_puzzle = 9;
                puzzle_row_col = 3;
                btn_size = 80;

                createButton();

                timer.Reset();
                time_label.Text = "00:00:00";
            }
        }

        private void createButton()
        {
            Size resize = new Size(240, 240);           // 240 x 240 으로 사진크기 수정
            Image re_image = new Bitmap(img, resize);
            Graphics G = Graphics.FromImage(re_image);
            
            btn = new Button[num_of_puzzle];            // 버튼 생성 
            piece_image = new Image[num_of_puzzle];     // 이미지 생성
            PuzzleTable = new int[puzzle_row_col, puzzle_row_col]; // 가상테이블 생성

            int Point_X;
            int Point_Y;

            for (int i = 0; i < btn.Length; i++)
            {
                // Point_X = 0, 1, 2, 0, 1, 2, 0, 1, 2 혹은
                // Point_X = 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3
                Point_X = (i % puzzle_row_col);
                // Point_X = 0, 0, 0, 1, 1, 1, 2, 2, 2 혹은
                // Point_X = 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2
                Point_Y = (i / puzzle_row_col);
                btn[i] = new Button();
                btn[i].Name = i.ToString();
                btn[i].Size = new Size(btn_size, btn_size);
                btn[i].Location = new Point(btn_size * Point_X, btn_size * Point_Y);
                btn[i].Font = new Font("굴림", 8);
                btn[i].Click += new EventHandler(OnClick);
                
                Bitmap bmp = new Bitmap(btn_size, btn_size, G); // 버튼 크기의 이미지 틀 생성
                Graphics g = Graphics.FromImage(bmp);

                // 이미지 자르기
                g.DrawImage(re_image, 0, 0, new Rectangle(Point_X * btn_size, Point_Y * btn_size, btn_size, btn_size), GraphicsUnit.Pixel);
                panel1.Controls.Add(btn[i]);              // panel1에 버튼 배열 추가
                this.piece_image[i] = btn[i].Image = bmp; // 조각 이미지 배열 = 버튼 배열.image = bmp
            }
        }

        // 퍼즐 섞기
        private void shuffle()
        {
            int[] ran_num_arr = new int[num_of_puzzle];  // 랜덤 생성한 번호들을 모아놓기 위한 배열
            int ran_num;                                 // 랜덤 생성한 숫자를 담을 변수
            Random rand = new Random();
            for (int i = 0; i < num_of_puzzle; i++)
            {
                reRandom:                                // goto문 받는 곳
                ran_num = rand.Next(num_of_puzzle) + 1;  // 난수 생성 ran_num = 1~9
                foreach (int j in ran_num_arr)           // 기존에 생성된 번호인지 확인
                {
                    if (j == ran_num)                    // 이미 생성된 번호 일때
                        goto reRandom;                   // reRandom 으로
                }
                ran_num_arr[i] = ran_num;                // 랜덤 생성한 번호들을 모아놓기 위한 배열
                btn[i].Image = piece_image[ran_num - 1]; // 퍼즐 버튼에 랜덤 이미지 작성
                btn[i].Text = ran_num.ToString();
                if (ran_num == num_of_puzzle)            // 마지막 퍼즐은 보이지 않게 설정
                    btn[i].Visible = false;
            }
            //2차원 배열(PuzzleTable)에 현재 대입된 값들을 할당한다. (숨김 버튼 위치 찾기)
            int k = 0;
            for (int row = 0; row < puzzle_row_col; row++)
            {
                for (int col = 0; col < puzzle_row_col; col++)
                {
                    PuzzleTable[row, col] = ran_num_arr[k]; // 2차원 배열에 현재 버튼
                    if (ran_num_arr[k] == num_of_puzzle)    // 퍼즐상태 확인 테이블에 숨김 버튼 위치 저장
                    {
                        //숨겨진 버튼의 전역변수에 저장
                        this.ROW = row;
                        this.COL = col;
                        this.NUM = k;
                    }
                    k++;
                }
            }
        }

        // 퍼즐 클릭 이벤트
        public void OnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;                        // 클릭한 버튼의 객체를 가져옴
            movePuzzle(Convert.ToInt32(btn.Name), btn.Text);    // 버튼의 아이디와 텍스트를 보냄
        }

        // 퍼즐 이동
        private void movePuzzle(int count, string btn_text)
        {
            // 현재 클릭한 버튼의 위치찾기 (2차원배열)
            int row, col = 0;
            for (row = 0; row < puzzle_row_col; row++)
            {
                for (col = 0; col < puzzle_row_col; col++)
                {
                    // 현재 할당된 행과 열을 찾앗을경우 Check_Move로
                    if (PuzzleTable[row, col] == Convert.ToInt32(btn_text))
                        goto Check_Move;
                }
            }
            Check_Move:     // goto문 받는 곳
            bool moving = false;
            if ((ROW == row) && Math.Abs(COL - col) == 1)   // 행으로 움직일 수 있는 상태인지 확인
                moving = true;      
            if ((COL == col) && Math.Abs(ROW - row) == 1)   // 열로 움직을 수 있는 상태인지 확인
                moving = true;
            if (!moving)    // 움직이지 못하는 상태면 리턴
                return;

            //숨겨진 버튼에 선택한 번호 옮겨놓기
            PuzzleTable[ROW, COL] = Convert.ToInt32(btn_text);  // 숨겨진 버튼에 대입
            PuzzleTable[row, col] = num_of_puzzle;              // 클릭한 버튼은 빈 번호로

            //숨겨진 버튼에 클릭한 버튼의 이미지 텍스트 보여주기
            btn[NUM].Image = btn[count].Image;
            btn[NUM].Visible = true;
            btn[NUM].Text = btn_text;

            //클릭한 버튼 다시 숨기기
            btn[count].Text = num_of_puzzle.ToString();
            btn[count].Visible = false;
            btn[count].Image = piece_image[num_of_puzzle - 1];

            //숨겨진 번호들 업데이트
            this.ROW = row;
            this.COL = col;
            this.NUM = count;

            // 퍼즐을 다 맞췄는지 확인
            int compare = 0;
            for (row = 0; row < puzzle_row_col; row++)
            {
                for (col = 0; col < puzzle_row_col; col++)
                {
                    compare++;
                    if (PuzzleTable[row, col] != compare)
                    {
                        return;  // 하나라도 다를 경우 함수를 종료
                    }

                }
            }
            // 모두 통과한 경우
            YesOrNo = MessageBox.Show("축하합니다", "퍼즐 완성", MessageBoxButtons.OK, MessageBoxIcon.Question);
            timer.Stop();
        }

        // panel2 에 이미지 넣기
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(img, 0, 0, 200, 200);
        }

        #region 시작, 일시정지, 종료 버튼
        // 일시정지 버튼
        private void pausebtn_Click(object sender, EventArgs e)
        {
            if (pausebtn.Text == "일시정지")
            {
                timer.Stop();
                panel1.Visible = false;
                panel2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                pause_label.Visible = true;
                pausebtn.Text = "재시작";
            }
            else
            {
                timer.Start();
                panel1.Visible = true;
                panel2.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                pause_label.Visible = false;
                pausebtn.Text = "일시정지";
            }
        }

        // 종료 버튼
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 시작 버튼
        private void startbtn_Click(object sender, EventArgs e)
        {
            shuffle();   // 이미지 섞기
            if (time_label.Text == "00:00:00")
                timer.Start();
        }
        #endregion

        // 타이머
        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                time_label.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                pausebtn.Enabled = false;
            else
                pausebtn.Enabled = true;
        }

        #region menuStrip 이미지 선택 (1~5)
        private void img_5_Click(object sender, EventArgs e)
        {
            img = new Bitmap(Properties.Resources._5);
            panel2.BackgroundImage = new Bitmap(img, resize);
        }

        private void img_4_Click(object sender, EventArgs e)
        {
            img = new Bitmap(Properties.Resources._4);
            panel2.BackgroundImage = new Bitmap(img, resize);
        }

        private void img_3_Click(object sender, EventArgs e)
        {
            img = new Bitmap(Properties.Resources._3);
            panel2.BackgroundImage = new Bitmap(img, resize);
        }

        private void img_2_Click(object sender, EventArgs e)
        {
            img = new Bitmap(Properties.Resources._2);
            panel2.BackgroundImage = new Bitmap(img, resize);
        }

        private void img_1_Click(object sender, EventArgs e)
        {
            img = new Bitmap(Properties.Resources._1);
            panel2.BackgroundImage = new Bitmap(img, resize);
        }
        #endregion
    }
}