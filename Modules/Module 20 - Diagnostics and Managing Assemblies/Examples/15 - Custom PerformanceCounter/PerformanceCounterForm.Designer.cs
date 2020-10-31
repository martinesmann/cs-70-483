namespace Wincubate.Module20.Slide15
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
         this.btnCreatePerformanceCounterCategory.Location = new System.Drawing.Point( 12, 12 );
         this.btnCreatePerformanceCounterCategory.Name = "btnCreatePerformanceCounterCategory";
         this.btnCreatePerformanceCounterCategory.Size = new System.Drawing.Size( 264, 23 );
         this.btnCreatePerformanceCounterCategory.TabIndex = 0;
         this.btnCreatePerformanceCounterCategory.Text = "Create PerformanceCounter Category";
         this.btnCreatePerformanceCounterCategory.UseVisualStyleBackColor = true;
         this.btnCreatePerformanceCounterCategory.Click += new System.EventHandler( this.btnCreatePerformanceCounter_Click );
         // 
         // btnCreatePerformanceCounter
         // 
         this.btnCreatePerformanceCounter.Location = new System.Drawing.Point( 12, 41 );
         this.btnCreatePerformanceCounter.Name = "btnCreatePerformanceCounter";
         this.btnCreatePerformanceCounter.Size = new System.Drawing.Size( 264, 23 );
         this.btnCreatePerformanceCounter.TabIndex = 1;
         this.btnCreatePerformanceCounter.Text = "Create PerformanceCounter";
         this.btnCreatePerformanceCounter.UseVisualStyleBackColor = true;
         this.btnCreatePerformanceCounter.Click += new System.EventHandler( this.btnCreatePerformanceCounter_Click_1 );
         // 
         // btnCreateA
         // 
         this.btnCreateA.Location = new System.Drawing.Point( 12, 70 );
         this.btnCreateA.Name = "btnCreateA";
         this.btnCreateA.Size = new System.Drawing.Size( 264, 23 );
         this.btnCreateA.TabIndex = 2;
         this.btnCreateA.Text = "Create A Instance";
         this.btnCreateA.UseVisualStyleBackColor = true;
         this.btnCreateA.Click += new System.EventHandler( this.btnCreateA_Click );
         // 
         // btnDisposeA
         // 
         this.btnDisposeA.Location = new System.Drawing.Point( 12, 99 );
         this.btnDisposeA.Name = "btnDisposeA";
         this.btnDisposeA.Size = new System.Drawing.Size( 264, 23 );
         this.btnDisposeA.TabIndex = 3;
         this.btnDisposeA.Text = "Dispose A Instance";
         this.btnDisposeA.UseVisualStyleBackColor = true;
         this.btnDisposeA.Click += new System.EventHandler( this.btnDisposeA_Click );
         // 
         // btnGetCounterValue
         // 
         this.btnGetCounterValue.Location = new System.Drawing.Point( 12, 128 );
         this.btnGetCounterValue.Name = "btnGetCounterValue";
         this.btnGetCounterValue.Size = new System.Drawing.Size( 264, 23 );
         this.btnGetCounterValue.TabIndex = 4;
         this.btnGetCounterValue.Text = "Read Counter Value";
         this.btnGetCounterValue.UseVisualStyleBackColor = true;
         this.btnGetCounterValue.Click += new System.EventHandler( this.btnGetCounterValue_Click );
         // 
         // btnDeletePerformanceCounterCategory
         // 
         this.btnDeletePerformanceCounterCategory.Location = new System.Drawing.Point( 12, 157 );
         this.btnDeletePerformanceCounterCategory.Name = "btnDeletePerformanceCounterCategory";
         this.btnDeletePerformanceCounterCategory.Size = new System.Drawing.Size( 264, 23 );
         this.btnDeletePerformanceCounterCategory.TabIndex = 5;
         this.btnDeletePerformanceCounterCategory.Text = "Delete PerformanceCounter Category";
         this.btnDeletePerformanceCounterCategory.UseVisualStyleBackColor = true;
         this.btnDeletePerformanceCounterCategory.Click += new System.EventHandler( this.btnDeletePerformanceCounterCategory_Click );
         // 
         // PerformanceCounterForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 293, 225 );
         this.Controls.Add( this.btnDeletePerformanceCounterCategory );
         this.Controls.Add( this.btnGetCounterValue );
         this.Controls.Add( this.btnDisposeA );
         this.Controls.Add( this.btnCreateA );
         this.Controls.Add( this.btnCreatePerformanceCounter );
         this.Controls.Add( this.btnCreatePerformanceCounterCategory );
         this.Name = "PerformanceCounterForm";
         this.Text = "PerformanceCounter Form";
         this.ResumeLayout( false );

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

