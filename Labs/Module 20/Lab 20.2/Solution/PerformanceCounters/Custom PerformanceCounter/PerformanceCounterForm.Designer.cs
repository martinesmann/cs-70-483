namespace CustomPerformanceCounter
{
   partial class PerformanceCounterForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btnCreatePerformanceCounterCategory = new System.Windows.Forms.Button();
         this.btnCreatePerformanceCounter = new System.Windows.Forms.Button();
         this.btnCreateA = new System.Windows.Forms.Button();
         this.btnDisposeA = new System.Windows.Forms.Button();
         this.btnGetCounterValue = new System.Windows.Forms.Button();
         this.btnDeletePerformanceCounterCategory = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnCreatePerformanceCounterCategory
         // 
         this.btnCreatePerformanceCounterCategory.Location = new System.Drawing.Point(16, 15);
         this.btnCreatePerformanceCounterCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnCreatePerformanceCounterCategory.Name = "btnCreatePerformanceCounterCategory";
         this.btnCreatePerformanceCounterCategory.Size = new System.Drawing.Size(352, 28);
         this.btnCreatePerformanceCounterCategory.TabIndex = 0;
         this.btnCreatePerformanceCounterCategory.Text = "Create PerformanceCounter Category";
         this.btnCreatePerformanceCounterCategory.UseVisualStyleBackColor = true;
         this.btnCreatePerformanceCounterCategory.Click += new System.EventHandler(this.OnCreatePerformanceCounterCategoryClick);
         // 
         // btnCreatePerformanceCounter
         // 
         this.btnCreatePerformanceCounter.Location = new System.Drawing.Point(16, 50);
         this.btnCreatePerformanceCounter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnCreatePerformanceCounter.Name = "btnCreatePerformanceCounter";
         this.btnCreatePerformanceCounter.Size = new System.Drawing.Size(352, 28);
         this.btnCreatePerformanceCounter.TabIndex = 1;
         this.btnCreatePerformanceCounter.Text = "Create PerformanceCounter";
         this.btnCreatePerformanceCounter.UseVisualStyleBackColor = true;
         this.btnCreatePerformanceCounter.Click += new System.EventHandler(this.OnCreatePerformanceCountersClick);
         // 
         // btnCreateA
         // 
         this.btnCreateA.Location = new System.Drawing.Point(16, 86);
         this.btnCreateA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnCreateA.Name = "btnCreateA";
         this.btnCreateA.Size = new System.Drawing.Size(352, 28);
         this.btnCreateA.TabIndex = 2;
         this.btnCreateA.Text = "Create A Instance";
         this.btnCreateA.UseVisualStyleBackColor = true;
         this.btnCreateA.Click += new System.EventHandler(this.OnCreateAInstanceClick);
         // 
         // btnDisposeA
         // 
         this.btnDisposeA.Location = new System.Drawing.Point(16, 122);
         this.btnDisposeA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnDisposeA.Name = "btnDisposeA";
         this.btnDisposeA.Size = new System.Drawing.Size(352, 28);
         this.btnDisposeA.TabIndex = 3;
         this.btnDisposeA.Text = "Dispose A Instance";
         this.btnDisposeA.UseVisualStyleBackColor = true;
         this.btnDisposeA.Click += new System.EventHandler(this.OnDisposeAInstanceClick);
         // 
         // btnGetCounterValue
         // 
         this.btnGetCounterValue.Location = new System.Drawing.Point(16, 158);
         this.btnGetCounterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnGetCounterValue.Name = "btnGetCounterValue";
         this.btnGetCounterValue.Size = new System.Drawing.Size(352, 28);
         this.btnGetCounterValue.TabIndex = 4;
         this.btnGetCounterValue.Text = "Read Counter Value";
         this.btnGetCounterValue.UseVisualStyleBackColor = true;
         this.btnGetCounterValue.Click += new System.EventHandler(this.OnGetCounterValueClick);
         // 
         // btnDeletePerformanceCounterCategory
         // 
         this.btnDeletePerformanceCounterCategory.Location = new System.Drawing.Point(16, 193);
         this.btnDeletePerformanceCounterCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnDeletePerformanceCounterCategory.Name = "btnDeletePerformanceCounterCategory";
         this.btnDeletePerformanceCounterCategory.Size = new System.Drawing.Size(352, 28);
         this.btnDeletePerformanceCounterCategory.TabIndex = 5;
         this.btnDeletePerformanceCounterCategory.Text = "Delete PerformanceCounter Category";
         this.btnDeletePerformanceCounterCategory.UseVisualStyleBackColor = true;
         this.btnDeletePerformanceCounterCategory.Click += new System.EventHandler(this.OnDeletePerformanceCounterCategoryClick);
         // 
         // PerformanceCounterForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(391, 260);
         this.Controls.Add(this.btnDeletePerformanceCounterCategory);
         this.Controls.Add(this.btnGetCounterValue);
         this.Controls.Add(this.btnDisposeA);
         this.Controls.Add(this.btnCreateA);
         this.Controls.Add(this.btnCreatePerformanceCounter);
         this.Controls.Add(this.btnCreatePerformanceCounterCategory);
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "PerformanceCounterForm";
         this.Text = "PerformanceCounter Form";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnCreatePerformanceCounterCategory;
      private System.Windows.Forms.Button btnCreatePerformanceCounter;
      private System.Windows.Forms.Button btnCreateA;
      private System.Windows.Forms.Button btnDisposeA;
      private System.Windows.Forms.Button btnGetCounterValue;
      private System.Windows.Forms.Button btnDeletePerformanceCounterCategory;
   }
}

