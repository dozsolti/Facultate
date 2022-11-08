namespace BillAI
{
    partial class Setari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarBallSize = new System.Windows.Forms.TrackBar();
            this.trackBarTimeScale = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarGenerationsCount = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarMutationChance = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarMinShootCount = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarMaxShootCount = new System.Windows.Forms.TrackBar();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBallSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGenerationsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMutationChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinShootCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxShootCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dimensiunea bilelor";
            // 
            // trackBarBallSize
            // 
            this.trackBarBallSize.Location = new System.Drawing.Point(32, 66);
            this.trackBarBallSize.Maximum = 80;
            this.trackBarBallSize.Minimum = 10;
            this.trackBarBallSize.Name = "trackBarBallSize";
            this.trackBarBallSize.Size = new System.Drawing.Size(297, 45);
            this.trackBarBallSize.TabIndex = 1;
            this.trackBarBallSize.TickFrequency = 5;
            this.trackBarBallSize.Value = 10;
            this.trackBarBallSize.Scroll += new System.EventHandler(this.trackBarBallSize_Scroll);
            // 
            // trackBarTimeScale
            // 
            this.trackBarTimeScale.Location = new System.Drawing.Point(32, 184);
            this.trackBarTimeScale.Minimum = 1;
            this.trackBarTimeScale.Name = "trackBarTimeScale";
            this.trackBarTimeScale.Size = new System.Drawing.Size(297, 45);
            this.trackBarTimeScale.TabIndex = 5;
            this.trackBarTimeScale.Value = 1;
            this.trackBarTimeScale.Scroll += new System.EventHandler(this.trackBarTimeScale_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Timpul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(427, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numărul de generații";
            // 
            // trackBarGenerationsCount
            // 
            this.trackBarGenerationsCount.Location = new System.Drawing.Point(431, 66);
            this.trackBarGenerationsCount.Maximum = 100;
            this.trackBarGenerationsCount.Minimum = 1;
            this.trackBarGenerationsCount.Name = "trackBarGenerationsCount";
            this.trackBarGenerationsCount.Size = new System.Drawing.Size(297, 45);
            this.trackBarGenerationsCount.TabIndex = 5;
            this.trackBarGenerationsCount.TickFrequency = 3;
            this.trackBarGenerationsCount.Value = 1;
            this.trackBarGenerationsCount.Scroll += new System.EventHandler(this.trackBarGenerationsCount_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(427, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Șansa pentru mutație";
            // 
            // trackBarMutationChance
            // 
            this.trackBarMutationChance.Location = new System.Drawing.Point(431, 189);
            this.trackBarMutationChance.Maximum = 100;
            this.trackBarMutationChance.Name = "trackBarMutationChance";
            this.trackBarMutationChance.Size = new System.Drawing.Size(297, 45);
            this.trackBarMutationChance.TabIndex = 5;
            this.trackBarMutationChance.Scroll += new System.EventHandler(this.trackBarMutationChance_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(427, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Numărul de lovituri minime";
            // 
            // trackBarMinShootCount
            // 
            this.trackBarMinShootCount.Location = new System.Drawing.Point(431, 338);
            this.trackBarMinShootCount.Minimum = 1;
            this.trackBarMinShootCount.Name = "trackBarMinShootCount";
            this.trackBarMinShootCount.Size = new System.Drawing.Size(297, 45);
            this.trackBarMinShootCount.TabIndex = 5;
            this.trackBarMinShootCount.Value = 1;
            this.trackBarMinShootCount.Scroll += new System.EventHandler(this.trackBarMinShootCount_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(435, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Numărul de lovituri maxime";
            // 
            // trackBarMaxShootCount
            // 
            this.trackBarMaxShootCount.Location = new System.Drawing.Point(431, 435);
            this.trackBarMaxShootCount.Minimum = 1;
            this.trackBarMaxShootCount.Name = "trackBarMaxShootCount";
            this.trackBarMaxShootCount.Size = new System.Drawing.Size(297, 45);
            this.trackBarMaxShootCount.TabIndex = 5;
            this.trackBarMaxShootCount.Value = 1;
            this.trackBarMaxShootCount.Scroll += new System.EventHandler(this.trackBarMaxShootCount_Scroll);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(950, 450);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(182, 60);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Continuă";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Setari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1158, 554);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.trackBarMaxShootCount);
            this.Controls.Add(this.trackBarMinShootCount);
            this.Controls.Add(this.trackBarMutationChance);
            this.Controls.Add(this.trackBarGenerationsCount);
            this.Controls.Add(this.trackBarTimeScale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarBallSize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Setari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setari";
            this.Load += new System.EventHandler(this.Setari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBallSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGenerationsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMutationChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinShootCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxShootCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarBallSize;
        private System.Windows.Forms.TrackBar trackBarTimeScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarGenerationsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarMutationChance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarMinShootCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarMaxShootCount;
        private System.Windows.Forms.Button buttonNext;
    }
}