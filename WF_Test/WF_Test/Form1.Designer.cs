namespace WF_Test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuInfo = new System.Windows.Forms.GroupBox();
            this.Btn_Run = new System.Windows.Forms.Button();
            this.Btn_Item = new System.Windows.Forms.Button();
            this.Btn_Skill = new System.Windows.Forms.Button();
            this.Btn_Atk = new System.Windows.Forms.Button();
            this.MonsterInfo = new System.Windows.Forms.GroupBox();
            this.label_Mon_MP = new System.Windows.Forms.Label();
            this.label_Mon_HP = new System.Windows.Forms.Label();
            this.Mon_MP = new System.Windows.Forms.ProgressBar();
            this.Mon_HP = new System.Windows.Forms.ProgressBar();
            this.PlayerInfo = new System.Windows.Forms.GroupBox();
            this.label_Player_MP = new System.Windows.Forms.Label();
            this.label_Player_HP = new System.Windows.Forms.Label();
            this.Player_MP = new System.Windows.Forms.ProgressBar();
            this.Player_HP = new System.Windows.Forms.ProgressBar();
            this.MessageInfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pic_Mon = new System.Windows.Forms.PictureBox();
            this.MenuInfo.SuspendLayout();
            this.MonsterInfo.SuspendLayout();
            this.PlayerInfo.SuspendLayout();
            this.MessageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Mon)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuInfo
            // 
            this.MenuInfo.Controls.Add(this.Btn_Run);
            this.MenuInfo.Controls.Add(this.Btn_Item);
            this.MenuInfo.Controls.Add(this.Btn_Skill);
            this.MenuInfo.Controls.Add(this.Btn_Atk);
            this.MenuInfo.Location = new System.Drawing.Point(27, 21);
            this.MenuInfo.Name = "MenuInfo";
            this.MenuInfo.Size = new System.Drawing.Size(94, 152);
            this.MenuInfo.TabIndex = 0;
            this.MenuInfo.TabStop = false;
            this.MenuInfo.Text = "메뉴";
            // 
            // Btn_Run
            // 
            this.Btn_Run.Location = new System.Drawing.Point(6, 107);
            this.Btn_Run.Name = "Btn_Run";
            this.Btn_Run.Size = new System.Drawing.Size(75, 23);
            this.Btn_Run.TabIndex = 0;
            this.Btn_Run.Text = "도망";
            this.Btn_Run.UseVisualStyleBackColor = true;
            this.Btn_Run.Click += new System.EventHandler(this.Btn_Run_Click);
            // 
            // Btn_Item
            // 
            this.Btn_Item.Location = new System.Drawing.Point(6, 78);
            this.Btn_Item.Name = "Btn_Item";
            this.Btn_Item.Size = new System.Drawing.Size(75, 23);
            this.Btn_Item.TabIndex = 0;
            this.Btn_Item.Text = "아이템";
            this.Btn_Item.UseVisualStyleBackColor = true;
            this.Btn_Item.Click += new System.EventHandler(this.Btn_Item_Click);
            // 
            // Btn_Skill
            // 
            this.Btn_Skill.Location = new System.Drawing.Point(6, 49);
            this.Btn_Skill.Name = "Btn_Skill";
            this.Btn_Skill.Size = new System.Drawing.Size(75, 23);
            this.Btn_Skill.TabIndex = 0;
            this.Btn_Skill.Text = "마법";
            this.Btn_Skill.UseVisualStyleBackColor = true;
            this.Btn_Skill.Click += new System.EventHandler(this.Btn_Skill_Click);
            // 
            // Btn_Atk
            // 
            this.Btn_Atk.Location = new System.Drawing.Point(6, 20);
            this.Btn_Atk.Name = "Btn_Atk";
            this.Btn_Atk.Size = new System.Drawing.Size(75, 23);
            this.Btn_Atk.TabIndex = 0;
            this.Btn_Atk.Text = "공격";
            this.Btn_Atk.UseVisualStyleBackColor = true;
            this.Btn_Atk.Click += new System.EventHandler(this.Btn_Atk_Click);
            // 
            // MonsterInfo
            // 
            this.MonsterInfo.Controls.Add(this.label_Mon_MP);
            this.MonsterInfo.Controls.Add(this.label_Mon_HP);
            this.MonsterInfo.Controls.Add(this.Mon_MP);
            this.MonsterInfo.Controls.Add(this.Mon_HP);
            this.MonsterInfo.Location = new System.Drawing.Point(161, 29);
            this.MonsterInfo.Name = "MonsterInfo";
            this.MonsterInfo.Size = new System.Drawing.Size(574, 181);
            this.MonsterInfo.TabIndex = 1;
            this.MonsterInfo.TabStop = false;
            this.MonsterInfo.Text = "몬스터정보";
            // 
            // label_Mon_MP
            // 
            this.label_Mon_MP.AutoSize = true;
            this.label_Mon_MP.Location = new System.Drawing.Point(42, 110);
            this.label_Mon_MP.Name = "label_Mon_MP";
            this.label_Mon_MP.Size = new System.Drawing.Size(24, 12);
            this.label_Mon_MP.TabIndex = 1;
            this.label_Mon_MP.Text = "MP";
            // 
            // label_Mon_HP
            // 
            this.label_Mon_HP.AutoSize = true;
            this.label_Mon_HP.Location = new System.Drawing.Point(42, 61);
            this.label_Mon_HP.Name = "label_Mon_HP";
            this.label_Mon_HP.Size = new System.Drawing.Size(21, 12);
            this.label_Mon_HP.TabIndex = 1;
            this.label_Mon_HP.Text = "HP";
            // 
            // Mon_MP
            // 
            this.Mon_MP.Location = new System.Drawing.Point(85, 99);
            this.Mon_MP.Name = "Mon_MP";
            this.Mon_MP.Size = new System.Drawing.Size(471, 45);
            this.Mon_MP.TabIndex = 0;
            // 
            // Mon_HP
            // 
            this.Mon_HP.Location = new System.Drawing.Point(85, 42);
            this.Mon_HP.Name = "Mon_HP";
            this.Mon_HP.Size = new System.Drawing.Size(471, 45);
            this.Mon_HP.TabIndex = 0;
            this.Mon_HP.Click += new System.EventHandler(this.Mon_HP_Click);
            // 
            // PlayerInfo
            // 
            this.PlayerInfo.Controls.Add(this.label_Player_MP);
            this.PlayerInfo.Controls.Add(this.label_Player_HP);
            this.PlayerInfo.Controls.Add(this.Player_MP);
            this.PlayerInfo.Controls.Add(this.Player_HP);
            this.PlayerInfo.Location = new System.Drawing.Point(33, 280);
            this.PlayerInfo.Name = "PlayerInfo";
            this.PlayerInfo.Size = new System.Drawing.Size(428, 132);
            this.PlayerInfo.TabIndex = 2;
            this.PlayerInfo.TabStop = false;
            this.PlayerInfo.Text = "플레이어";
            // 
            // label_Player_MP
            // 
            this.label_Player_MP.AutoSize = true;
            this.label_Player_MP.Location = new System.Drawing.Point(6, 87);
            this.label_Player_MP.Name = "label_Player_MP";
            this.label_Player_MP.Size = new System.Drawing.Size(24, 12);
            this.label_Player_MP.TabIndex = 1;
            this.label_Player_MP.Text = "MP";
            // 
            // label_Player_HP
            // 
            this.label_Player_HP.AutoSize = true;
            this.label_Player_HP.Location = new System.Drawing.Point(6, 43);
            this.label_Player_HP.Name = "label_Player_HP";
            this.label_Player_HP.Size = new System.Drawing.Size(21, 12);
            this.label_Player_HP.TabIndex = 1;
            this.label_Player_HP.Text = "HP";
            // 
            // Player_MP
            // 
            this.Player_MP.Location = new System.Drawing.Point(54, 75);
            this.Player_MP.Name = "Player_MP";
            this.Player_MP.Size = new System.Drawing.Size(352, 39);
            this.Player_MP.TabIndex = 0;
            // 
            // Player_HP
            // 
            this.Player_HP.Location = new System.Drawing.Point(54, 30);
            this.Player_HP.Name = "Player_HP";
            this.Player_HP.Size = new System.Drawing.Size(352, 39);
            this.Player_HP.TabIndex = 0;
            // 
            // MessageInfo
            // 
            this.MessageInfo.Controls.Add(this.label5);
            this.MessageInfo.Location = new System.Drawing.Point(33, 472);
            this.MessageInfo.Name = "MessageInfo";
            this.MessageInfo.Size = new System.Drawing.Size(702, 132);
            this.MessageInfo.TabIndex = 2;
            this.MessageInfo.TabStop = false;
            this.MessageInfo.Text = "메세지";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "메세지";
            // 
            // Pic_Mon
            // 
            this.Pic_Mon.Location = new System.Drawing.Point(473, 226);
            this.Pic_Mon.Name = "Pic_Mon";
            this.Pic_Mon.Size = new System.Drawing.Size(262, 228);
            this.Pic_Mon.TabIndex = 3;
            this.Pic_Mon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 616);
            this.Controls.Add(this.Pic_Mon);
            this.Controls.Add(this.MessageInfo);
            this.Controls.Add(this.PlayerInfo);
            this.Controls.Add(this.MonsterInfo);
            this.Controls.Add(this.MenuInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuInfo.ResumeLayout(false);
            this.MonsterInfo.ResumeLayout(false);
            this.MonsterInfo.PerformLayout();
            this.PlayerInfo.ResumeLayout(false);
            this.PlayerInfo.PerformLayout();
            this.MessageInfo.ResumeLayout(false);
            this.MessageInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Mon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MenuInfo;
        private System.Windows.Forms.Button Btn_Run;
        private System.Windows.Forms.Button Btn_Item;
        private System.Windows.Forms.Button Btn_Skill;
        private System.Windows.Forms.Button Btn_Atk;
        private System.Windows.Forms.GroupBox MonsterInfo;
        private System.Windows.Forms.Label label_Mon_MP;
        private System.Windows.Forms.Label label_Mon_HP;
        private System.Windows.Forms.ProgressBar Mon_MP;
        private System.Windows.Forms.ProgressBar Mon_HP;
        private System.Windows.Forms.GroupBox PlayerInfo;
        private System.Windows.Forms.Label label_Player_MP;
        private System.Windows.Forms.Label label_Player_HP;
        private System.Windows.Forms.ProgressBar Player_MP;
        private System.Windows.Forms.ProgressBar Player_HP;
        private System.Windows.Forms.GroupBox MessageInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Pic_Mon;

        
    }
}

