namespace CrossColoursCS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tlp_game = new System.Windows.Forms.TableLayoutPanel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            this.nud_rows = new System.Windows.Forms.NumericUpDown();
            this.nud_cols = new System.Windows.Forms.NumericUpDown();
            this.btn_generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cols)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_game
            // 
            this.tlp_game.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_game.ColumnCount = 6;
            this.tlp_game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.Location = new System.Drawing.Point(12, 69);
            this.tlp_game.Name = "tlp_game";
            this.tlp_game.RowCount = 6;
            this.tlp_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_game.Size = new System.Drawing.Size(460, 438);
            this.tlp_game.TabIndex = 0;
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset.Location = new System.Drawing.Point(16, 513);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // pcb_logo
            // 
            this.pcb_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_logo.Image = global::CrossColoursCS.Properties.Resources.brainbashers;
            this.pcb_logo.Location = new System.Drawing.Point(12, 2);
            this.pcb_logo.Name = "pcb_logo";
            this.pcb_logo.Size = new System.Drawing.Size(460, 61);
            this.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_logo.TabIndex = 2;
            this.pcb_logo.TabStop = false;
            this.pcb_logo.Click += new System.EventHandler(this.pcb_logo_Click);
            // 
            // nud_rows
            // 
            this.nud_rows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_rows.Location = new System.Drawing.Point(263, 516);
            this.nud_rows.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nud_rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_rows.Name = "nud_rows";
            this.nud_rows.Size = new System.Drawing.Size(58, 20);
            this.nud_rows.TabIndex = 3;
            this.nud_rows.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // nud_cols
            // 
            this.nud_cols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_cols.Location = new System.Drawing.Point(327, 516);
            this.nud_cols.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nud_cols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_cols.Name = "nud_cols";
            this.nud_cols.Size = new System.Drawing.Size(58, 20);
            this.nud_cols.TabIndex = 4;
            this.nud_cols.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // btn_generate
            // 
            this.btn_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_generate.Location = new System.Drawing.Point(391, 513);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 5;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 548);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.nud_cols);
            this.Controls.Add(this.nud_rows);
            this.Controls.Add(this.pcb_logo);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.tlp_game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(334, 405);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cross Colours CS";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cols)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_game;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.PictureBox pcb_logo;
        private System.Windows.Forms.NumericUpDown nud_rows;
        private System.Windows.Forms.NumericUpDown nud_cols;
        private System.Windows.Forms.Button btn_generate;
    }
}

