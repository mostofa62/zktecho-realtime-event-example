namespace TripodAccessMultiTasking
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ServiceId = new System.Windows.Forms.Label();
            this.MobileNumber = new System.Windows.Forms.Label();
            this.OfficerName = new System.Windows.Forms.Label();
            this.Rank = new System.Windows.Forms.Label();
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ONLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RankLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceId
            // 
            this.ServiceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ServiceId.AutoSize = true;
            this.ServiceId.BackColor = System.Drawing.SystemColors.Control;
            this.ServiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceId.ForeColor = System.Drawing.Color.Navy;
            this.ServiceId.Location = new System.Drawing.Point(422, 200);
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.Size = new System.Drawing.Size(223, 76);
            this.ServiceId.TabIndex = 4;
            //this.ServiceId.Text = "10002";
            this.ServiceId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MobileNumber
            // 
            this.MobileNumber.AutoSize = true;
            this.MobileNumber.BackColor = System.Drawing.SystemColors.Control;
            this.MobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNumber.ForeColor = System.Drawing.Color.Navy;
            this.MobileNumber.Location = new System.Drawing.Point(422, 352);
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Size = new System.Drawing.Size(223, 76);
            this.MobileNumber.TabIndex = 5;
            //this.MobileNumber.Text = "00002";
            // 
            // OfficerName
            // 
            this.OfficerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OfficerName.AutoSize = true;
            this.OfficerName.BackColor = System.Drawing.SystemColors.Control;
            this.TablePanel.SetColumnSpan(this.OfficerName, 5);
            this.OfficerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficerName.ForeColor = System.Drawing.Color.Navy;
            this.OfficerName.Location = new System.Drawing.Point(422, 0);
            this.OfficerName.Name = "OfficerName";
            this.OfficerName.Size = new System.Drawing.Size(1162, 200);
            this.OfficerName.TabIndex = 2;
            //this.OfficerName.Text = "Golam Mostofa Benarji Misti Modhur Sristi";
            this.OfficerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rank
            // 
            this.Rank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Rank.AutoSize = true;
            this.Rank.BackColor = System.Drawing.SystemColors.Control;
            this.Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rank.ForeColor = System.Drawing.Color.Navy;
            this.Rank.Location = new System.Drawing.Point(422, 276);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(426, 76);
            this.Rank.TabIndex = 3;
            //this.Rank.Text = "Kolam Barak";
            this.Rank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rank.Click += new System.EventHandler(this.Rank_Click);
            // 
            // TablePanel
            // 
            this.TablePanel.AutoSize = true;
            this.TablePanel.BackColor = System.Drawing.SystemColors.Menu;
            this.TablePanel.ColumnCount = 7;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 565F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TablePanel.Controls.Add(this.MobileNumber, 2, 3);
            this.TablePanel.Controls.Add(this.pictureBox1, 4, 1);
            this.TablePanel.Controls.Add(this.ONLabel, 1, 1);
            this.TablePanel.Controls.Add(this.OfficerName, 2, 0);
            this.TablePanel.Controls.Add(this.ServiceId, 2, 1);
            this.TablePanel.Controls.Add(this.Rank, 2, 2);
            this.TablePanel.Controls.Add(this.NameLabel, 1, 0);
            this.TablePanel.Controls.Add(this.RankLabel, 1, 2);
            this.TablePanel.Controls.Add(this.label1, 1, 3);
            this.TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel.Location = new System.Drawing.Point(0, 0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 6;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.Size = new System.Drawing.Size(1370, 749);
            this.TablePanel.TabIndex = 6;
            this.TablePanel.Visible = false;
            this.TablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(1042, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.TablePanel.SetRowSpan(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(559, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ONLabel
            // 
            this.ONLabel.AutoSize = true;
            this.ONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ONLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ONLabel.Location = new System.Drawing.Point(22, 200);
            this.ONLabel.Name = "ONLabel";
            this.ONLabel.Size = new System.Drawing.Size(189, 76);
            this.ONLabel.TabIndex = 6;
            this.ONLabel.Text = "O.No";
            this.ONLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameLabel.Location = new System.Drawing.Point(22, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(211, 200);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RankLabel.Location = new System.Drawing.Point(22, 276);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(189, 76);
            this.RankLabel.TabIndex = 8;
            this.RankLabel.Text = "Rank";
            this.RankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RankLabel.Click += new System.EventHandler(this.RankLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 76);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mobile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TripodAccessMultiTasking.Properties.Resources.background_image2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.TablePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label ServiceId;
        public System.Windows.Forms.Label MobileNumber;
        public System.Windows.Forms.Label OfficerName;
        public System.Windows.Forms.Label Rank;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ONLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TableLayoutPanel TablePanel;
    }
}