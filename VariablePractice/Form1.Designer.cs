
namespace VariablePractice
{
    partial class variablePractice
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
            this.hockeyButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.areaButton = new System.Windows.Forms.Button();
            this.carpetArea = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hockeyButton
            // 
            this.hockeyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hockeyButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hockeyButton.Location = new System.Drawing.Point(12, 12);
            this.hockeyButton.Name = "hockeyButton";
            this.hockeyButton.Size = new System.Drawing.Size(161, 95);
            this.hockeyButton.TabIndex = 0;
            this.hockeyButton.Text = "Hockey";
            this.hockeyButton.UseVisualStyleBackColor = true;
            this.hockeyButton.Click += new System.EventHandler(this.hockeyButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(179, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(730, 404);
            this.outputLabel.TabIndex = 1;
            // 
            // areaButton
            // 
            this.areaButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaButton.Location = new System.Drawing.Point(12, 113);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(161, 95);
            this.areaButton.TabIndex = 2;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // carpetArea
            // 
            this.carpetArea.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetArea.Location = new System.Drawing.Point(12, 214);
            this.carpetArea.Name = "carpetArea";
            this.carpetArea.Size = new System.Drawing.Size(161, 95);
            this.carpetArea.TabIndex = 3;
            this.carpetArea.Text = "Carpet";
            this.carpetArea.UseVisualStyleBackColor = true;
            this.carpetArea.Click += new System.EventHandler(this.carpetArea_Click);
            // 
            // billButton
            // 
            this.billButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.Location = new System.Drawing.Point(12, 315);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(161, 95);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // variablePractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(921, 422);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.carpetArea);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.hockeyButton);
            this.Name = "variablePractice";
            this.Text = "Variables Practice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hockeyButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button carpetArea;
        private System.Windows.Forms.Button billButton;
    }
}

