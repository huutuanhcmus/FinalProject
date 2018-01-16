namespace QuickNote2
{
    partial class TakeNote
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
            this.Note_textbox = new System.Windows.Forms.RichTextBox();
            this.Tag_textbox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Save_b = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Note_textbox
            // 
            this.Note_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Note_textbox.Location = new System.Drawing.Point(24, 228);
            this.Note_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Note_textbox.Name = "Note_textbox";
            this.Note_textbox.Size = new System.Drawing.Size(541, 152);
            this.Note_textbox.TabIndex = 1;
            this.Note_textbox.Text = "";
            this.Note_textbox.TextChanged += new System.EventHandler(this.Note_textbox_TextChanged);
            // 
            // Tag_textbox
            // 
            this.Tag_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tag_textbox.Location = new System.Drawing.Point(24, 139);
            this.Tag_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Tag_textbox.Name = "Tag_textbox";
            this.Tag_textbox.Size = new System.Drawing.Size(541, 27);
            this.Tag_textbox.TabIndex = 0;
            this.Tag_textbox.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 455);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(221, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "INSERT NOTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag";
            // 
            // Save_b
            // 
            this.Save_b.BackColor = System.Drawing.Color.White;
            this.Save_b.Location = new System.Drawing.Point(247, 399);
            this.Save_b.Margin = new System.Windows.Forms.Padding(4);
            this.Save_b.Name = "Save_b";
            this.Save_b.Size = new System.Drawing.Size(100, 28);
            this.Save_b.TabIndex = 2;
            this.Save_b.Text = "Save";
            this.Save_b.UseVisualStyleBackColor = false;
            this.Save_b.Click += new System.EventHandler(this.Save_b_Click);
            // 
            // TakeNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 473);
            this.Controls.Add(this.Save_b);
            this.Controls.Add(this.Tag_textbox);
            this.Controls.Add(this.Note_textbox);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TakeNote";
            this.Text = "Take Note";
            this.Load += new System.EventHandler(this.TakeNote_Load);
            this.Shown += new System.EventHandler(this.TakeNote_Shown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TakeNote_PreviewKeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Note_textbox;
        private System.Windows.Forms.RichTextBox Tag_textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save_b;
    }
}