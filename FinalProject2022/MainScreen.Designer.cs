
namespace FinalProject2022
{
    partial class MainScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.receiptLabel = new System.Windows.Forms.Label();
            this.produceButton = new System.Windows.Forms.Button();
            this.frozenButton = new System.Windows.Forms.Button();
            this.groceryButton1 = new System.Windows.Forms.Button();
            this.groceryButton2 = new System.Windows.Forms.Button();
            this.dairyButton = new System.Windows.Forms.Button();
            this.meatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // receiptLabel
            // 
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptLabel.Location = new System.Drawing.Point(758, 10);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(397, 666);
            this.receiptLabel.TabIndex = 0;
            this.receiptLabel.Text = "Order";
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // produceButton
            // 
            this.produceButton.Location = new System.Drawing.Point(13, 10);
            this.produceButton.Name = "produceButton";
            this.produceButton.Size = new System.Drawing.Size(366, 235);
            this.produceButton.TabIndex = 1;
            this.produceButton.Text = "Produce";
            this.produceButton.UseVisualStyleBackColor = true;
            this.produceButton.Click += new System.EventHandler(this.produceButton_Click);
            // 
            // frozenButton
            // 
            this.frozenButton.Location = new System.Drawing.Point(385, 10);
            this.frozenButton.Name = "frozenButton";
            this.frozenButton.Size = new System.Drawing.Size(367, 235);
            this.frozenButton.TabIndex = 2;
            this.frozenButton.Text = "Frozen";
            this.frozenButton.UseVisualStyleBackColor = true;
            this.frozenButton.Click += new System.EventHandler(this.frozenButton_Click);
            // 
            // groceryButton1
            // 
            this.groceryButton1.Location = new System.Drawing.Point(13, 251);
            this.groceryButton1.Name = "groceryButton1";
            this.groceryButton1.Size = new System.Drawing.Size(366, 213);
            this.groceryButton1.TabIndex = 3;
            this.groceryButton1.Text = "Grocery A - M";
            this.groceryButton1.UseVisualStyleBackColor = true;
            this.groceryButton1.Click += new System.EventHandler(this.groceryButton1_Click);
            // 
            // groceryButton2
            // 
            this.groceryButton2.Location = new System.Drawing.Point(385, 251);
            this.groceryButton2.Name = "groceryButton2";
            this.groceryButton2.Size = new System.Drawing.Size(367, 213);
            this.groceryButton2.TabIndex = 4;
            this.groceryButton2.Text = "Grocery N - Z";
            this.groceryButton2.UseVisualStyleBackColor = true;
            this.groceryButton2.Click += new System.EventHandler(this.groceryButton2_Click);
            // 
            // dairyButton
            // 
            this.dairyButton.Location = new System.Drawing.Point(13, 470);
            this.dairyButton.Name = "dairyButton";
            this.dairyButton.Size = new System.Drawing.Size(366, 206);
            this.dairyButton.TabIndex = 5;
            this.dairyButton.Text = "Dairy";
            this.dairyButton.UseVisualStyleBackColor = true;
            this.dairyButton.Click += new System.EventHandler(this.dairyButton_Click);
            // 
            // meatButton
            // 
            this.meatButton.Location = new System.Drawing.Point(385, 470);
            this.meatButton.Name = "meatButton";
            this.meatButton.Size = new System.Drawing.Size(367, 206);
            this.meatButton.TabIndex = 6;
            this.meatButton.Text = "Deli/Butcher";
            this.meatButton.UseVisualStyleBackColor = true;
            this.meatButton.Click += new System.EventHandler(this.meatButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.meatButton);
            this.Controls.Add(this.dairyButton);
            this.Controls.Add(this.groceryButton2);
            this.Controls.Add(this.groceryButton1);
            this.Controls.Add(this.frozenButton);
            this.Controls.Add(this.produceButton);
            this.Controls.Add(this.receiptLabel);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1170, 697);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button produceButton;
        private System.Windows.Forms.Button frozenButton;
        private System.Windows.Forms.Button groceryButton1;
        private System.Windows.Forms.Button groceryButton2;
        private System.Windows.Forms.Button dairyButton;
        private System.Windows.Forms.Button meatButton;
    }
}
