namespace recognitionApp
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.gpResults = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetected = new System.Windows.Forms.Button();
            this.gpTraining = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.lblNames = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.gpResults.SuspendLayout();
            this.gpTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // gpResults
            // 
            this.gpResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpResults.Controls.Add(this.label5);
            this.gpResults.Controls.Add(this.label4);
            this.gpResults.Controls.Add(this.label3);
            this.gpResults.Controls.Add(this.label2);
            this.gpResults.Controls.Add(this.btnDetected);
            this.gpResults.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpResults.Location = new System.Drawing.Point(588, 10);
            this.gpResults.Name = "gpResults";
            this.gpResults.Size = new System.Drawing.Size(283, 195);
            this.gpResults.TabIndex = 11;
            this.gpResults.TabStop = false;
            this.gpResults.Text = "Results: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Persons present in the scene:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nobody";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of faces detected: ";
            this.label2.Visible = false;
            // 
            // btnDetected
            // 
            this.btnDetected.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDetected.Location = new System.Drawing.Point(12, 131);
            this.btnDetected.Name = "btnDetected";
            this.btnDetected.Size = new System.Drawing.Size(264, 45);
            this.btnDetected.TabIndex = 2;
            this.btnDetected.Text = "Detect and recognize";
            this.btnDetected.UseVisualStyleBackColor = true;
            this.btnDetected.Click += new System.EventHandler(this.btnDetected_Click);
            // 
            // gpTraining
            // 
            this.gpTraining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpTraining.Controls.Add(this.imageBox1);
            this.gpTraining.Controls.Add(this.txtNames);
            this.gpTraining.Controls.Add(this.lblNames);
            this.gpTraining.Controls.Add(this.btnAdd);
            this.gpTraining.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTraining.Location = new System.Drawing.Point(588, 211);
            this.gpTraining.Name = "gpTraining";
            this.gpTraining.Size = new System.Drawing.Size(283, 213);
            this.gpTraining.TabIndex = 10;
            this.gpTraining.TabStop = false;
            this.gpTraining.Text = "Training: ";
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(14, 19);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(160, 118);
            this.imageBox1.TabIndex = 10;
            this.imageBox1.TabStop = false;
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(54, 143);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(120, 20);
            this.txtNames.TabIndex = 9;
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(11, 143);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(45, 13);
            this.lblNames.TabIndex = 8;
            this.lblNames.Text = "Name: ";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(14, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Face Single Time";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(12, 29);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(570, 389);
            this.imageBoxFrameGrabber.TabIndex = 12;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 436);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.gpResults);
            this.Controls.Add(this.gpTraining);
            this.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Reconnaissance faciale";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gpResults.ResumeLayout(false);
            this.gpResults.PerformLayout();
            this.gpTraining.ResumeLayout(false);
            this.gpTraining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetected;
        private System.Windows.Forms.GroupBox gpTraining;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNames;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
    }
}

