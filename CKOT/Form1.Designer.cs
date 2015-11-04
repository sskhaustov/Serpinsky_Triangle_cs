namespace CKOT
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.screen = new System.Windows.Forms.PictureBox();
            this.draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.t_step = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Button();
            this.draw_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.Control;
            this.screen.Location = new System.Drawing.Point(2, 3);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(510, 510);
            this.screen.TabIndex = 0;
            this.screen.TabStop = false;
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(409, 514);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(95, 23);
            this.draw.TabIndex = 1;
            this.draw.Text = "NEXT";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ШАГ:";
            // 
            // t_step
            // 
            this.t_step.AutoSize = true;
            this.t_step.Location = new System.Drawing.Point(54, 519);
            this.t_step.Name = "t_step";
            this.t_step.Size = new System.Drawing.Size(13, 13);
            this.t_step.TabIndex = 3;
            this.t_step.Text = "0";
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(224, 514);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(86, 23);
            this.res.TabIndex = 4;
            this.res.Text = "RESET";
            this.res.UseVisualStyleBackColor = true;
            this.res.Click += new System.EventHandler(this.res_Click);
            // 
            // draw_back
            // 
            this.draw_back.Location = new System.Drawing.Point(316, 514);
            this.draw_back.Name = "draw_back";
            this.draw_back.Size = new System.Drawing.Size(87, 23);
            this.draw_back.TabIndex = 5;
            this.draw_back.Text = "BACK";
            this.draw_back.UseVisualStyleBackColor = true;
            this.draw_back.Click += new System.EventHandler(this.draw_back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 540);
            this.Controls.Add(this.draw_back);
            this.Controls.Add(this.res);
            this.Controls.Add(this.t_step);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.screen);
            this.Name = "Form1";
            this.Text = "treugolnik_serpinskogo";
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label t_step;
        private System.Windows.Forms.Button res;
        private System.Windows.Forms.Button draw_back;
    }
}

