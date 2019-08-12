using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Chapter5.Delegates {
	/// <summary>
	/// Summary description for RegexTester.
	/// </summary>
	public class RegexTester : System.Windows.Forms.Form {

		private Rectangle[] Rectangles;
		private Compare[] CompareProcs;
		internal System.Windows.Forms.CheckBox CheckBoxShowSwaps;
		internal System.Windows.Forms.CheckBox CheckBoxAscending;
		internal System.Windows.Forms.MainMenu MainMenu1;
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.MenuItem MenuExit;
		internal System.Windows.Forms.MenuItem MenuItem3;
		internal System.Windows.Forms.MenuItem MenuRandomize;
		internal System.Windows.Forms.MenuItem MenuItem7;
		internal System.Windows.Forms.MenuItem MenuBubble;
		internal System.Windows.Forms.MenuItem MenuSelection;
		internal System.Windows.Forms.MenuItem menuQuick;
	
		public delegate bool Compare(int Height1, int Height2);

		private System.ComponentModel.Container components = null;

        public RegexTester()
        {
            base.Load += new EventHandler(this.RegexTester_Load);
			base.Paint += new PaintEventHandler(this.RegexTester_Paint);
			Rectangles = new Rectangle[300];
			//Create array of delegates
			CompareProcs = new Compare[]{new Compare(this.Less), new Compare(this.Greater)};
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		/// 
		static void Main() {
			Application.Run(new RegexTester());
		}
		private void InitializeComponent()
		{
			this.CheckBoxShowSwaps = new System.Windows.Forms.CheckBox();
			this.CheckBoxAscending = new System.Windows.Forms.CheckBox();
			this.MainMenu1 = new System.Windows.Forms.MainMenu();
			this.MenuItem1 = new System.Windows.Forms.MenuItem();
			this.MenuExit = new System.Windows.Forms.MenuItem();
			this.MenuItem3 = new System.Windows.Forms.MenuItem();
			this.MenuRandomize = new System.Windows.Forms.MenuItem();
			this.MenuItem7 = new System.Windows.Forms.MenuItem();
			this.MenuBubble = new System.Windows.Forms.MenuItem();
			this.MenuSelection = new System.Windows.Forms.MenuItem();
			this.menuQuick = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// CheckBoxShowSwaps
			// 
			this.CheckBoxShowSwaps.Checked = true;
			this.CheckBoxShowSwaps.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxShowSwaps.Location = new System.Drawing.Point(551, 397);
			this.CheckBoxShowSwaps.Name = "CheckBoxShowSwaps";
			this.CheckBoxShowSwaps.Size = new System.Drawing.Size(95, 23);
			this.CheckBoxShowSwaps.TabIndex = 3;
			this.CheckBoxShowSwaps.Text = "Show Swaps";
			// 
			// CheckBoxAscending
			// 
			this.CheckBoxAscending.Checked = true;
			this.CheckBoxAscending.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxAscending.Location = new System.Drawing.Point(551, 420);
			this.CheckBoxAscending.Name = "CheckBoxAscending";
			this.CheckBoxAscending.Size = new System.Drawing.Size(102, 22);
			this.CheckBoxAscending.TabIndex = 2;
			this.CheckBoxAscending.Text = "Ascending";
			// 
			// MainMenu1
			// 
			this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.MenuItem1,
																					  this.MenuItem3});
			// 
			// MenuItem1
			// 
			this.MenuItem1.Index = 0;
			this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.MenuExit});
			this.MenuItem1.Text = "&File";
			// 
			// MenuExit
			// 
			this.MenuExit.Index = 0;
			this.MenuExit.Text = "E&xit";
			this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
			// 
			// MenuItem3
			// 
			this.MenuItem3.Index = 1;
			this.MenuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.MenuRandomize,
																					  this.MenuItem7,
																					  this.MenuBubble,
																					  this.MenuSelection,
																					  this.menuQuick});
			this.MenuItem3.Text = "&Sort";
			// 
			// MenuRandomize
			// 
			this.MenuRandomize.Index = 0;
			this.MenuRandomize.Text = "Randomize";
			this.MenuRandomize.Click += new System.EventHandler(this.MenuRandomize_Click);
			// 
			// MenuItem7
			// 
			this.MenuItem7.Index = 1;
			this.MenuItem7.Text = "-";
			// 
			// MenuBubble
			// 
			this.MenuBubble.Index = 2;
			this.MenuBubble.Shortcut = System.Windows.Forms.Shortcut.F2;
			this.MenuBubble.Text = "Bubble";
			this.MenuBubble.Click += new System.EventHandler(this.MenuBubble_Click);
			// 
			// MenuSelection
			// 
			this.MenuSelection.Index = 3;
			this.MenuSelection.Shortcut = System.Windows.Forms.Shortcut.F3;
			this.MenuSelection.Text = "Selection";
			this.MenuSelection.Click += new System.EventHandler(this.MenuSelection_Click);
			// 
			// menuQuick
			// 
			this.menuQuick.Index = 4;
			this.menuQuick.Shortcut = System.Windows.Forms.Shortcut.F4;
			this.menuQuick.Text = "Quick";
			this.menuQuick.Click += new System.EventHandler(this.menuQuick_Click);
			// 
			// RegexTester
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 462);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.CheckBoxAscending,
																		  this.CheckBoxShowSwaps});
			this.Menu = this.MainMenu1;
			this.Name = "RegexTester";
			this.Text = "RegexTester";
			this.ResumeLayout(false);

		}
		#endregion

		private Compare GetCompareProc(bool Value) {
			return CompareProcs[Math.Abs(Convert.ToInt16(Value))];
		}

		private void DrawRandomBars() {
			Array.Clear(Rectangles, 0, Rectangles.GetUpperBound(0));
			int j = Rectangles.GetUpperBound(0);
			Random random = new Random();
			for (int i = Rectangles.GetLowerBound(0); i <= j; i++) {
				Rectangles[i] = new Rectangle(i * 2, 0, 1, random.Next(0,200));
			}
			base.Invalidate();
		}

		private void ConditionalInvalidate() {
			if (!CheckBoxShowSwaps.Checked) {
				base.Invalidate();
			}
		}

		private void DrawRectangle(Rectangle Rect, Pen APen) {
			base.CreateGraphics().DrawRectangle(APen, Rect);
		}

		private void RegexTester_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			base.CreateGraphics().DrawRectangles(Pens.Green, Rectangles);
		}

		public bool Greater(int H1, int H2) {
			return H1 > H2;
		}

		public bool Less(int H1, int H2) {
			return H1 < H2;
		}

		public void EraseOld(Rectangle[] Rects, int I, int J) {
			if (CheckBoxShowSwaps.Checked) {
				DrawRectangle(Rects[I], Pens.LightGray);
				DrawRectangle(Rects[J], Pens.LightGray);
			}
		}

		public void DrawNew(Rectangle[] Rects, int I, int J) {
			if (CheckBoxShowSwaps.Checked) {
				DrawRectangle(Rects[I], Pens.Green);
				DrawRectangle(Rects[J], Pens.Green);
			}
		}

		public void Swap(Rectangle[] Rects, int I, int J) {
			EraseOld(Rects, I, J);
			Rectangle rectangle = Rects[I];
			Rects[I] = Rects[J];
			Rects[J] = rectangle;
			int i = Rects[I].X;
			Rects[I].X = Rects[J].X;
			Rects[J].X = i;
			DrawNew(Rects, I, J);
		}

		public void BubbleSort(Rectangle[] Rects, Compare CompareProc) {
			int i2 = Rects.GetUpperBound(0) - 1;
			for (int i1 = 0; i1 <= i2; i1++) {
				int k = Rects.GetUpperBound(0);
				for (int j = i1 + 1; j <= k; j++) {
					Application.DoEvents();
					if (CompareProc(Rects[i1].Height, Rects[j].Height)) {
						Swap(Rects, i1, j);
					}
				}
			}
		}

		public void SelectionSort(Rectangle[] Rects, Compare CompareProc) {
			int j2 = Rects.GetUpperBound(0) - 1;
			for (int i1 = 0; i1 <= j2; i1++) {
				int k = i1;
				int i2 = Rects.GetUpperBound(0);
				for (int j1 = i1 + 1; j1 <= i2; j1++) {
					if (CompareProc(Rects[k].Height, Rects[j1].Height)) {
						k = j1;
					}
				}
				Swap(Rects, i1, k);
			}
		}

		public void QuickSort(Rectangle[] Rects, int Left, int Right, Compare Comp1, Compare Comp2) {
			if (Right > Left) {
				Rectangle rectangle = Rects[Right];
				int i = Left - 1;
				int j = Right;
				while (true) {
					do {
						i++;
					}
					while (Comp1(Rects[i].Height, rectangle.Height));
					do {
						j--;
					}
					while (j >= Rects.GetLowerBound(0) && Comp2(Rects[j].Height, rectangle.Height));
					if (i >= j) {
						break;
					}
					Swap(Rects, i, j);
				}
				Swap(Rects, i, Right);
				QuickSort(Rects, Left, i - 1, Comp1, Comp2);
				QuickSort(Rects, i + 1, Right, Comp1, Comp2);
			}
		}

		private void RegexTester_Load(object sender, System.EventArgs e) {
			DrawRandomBars();
		}

		private void MenuExit_Click(object sender, System.EventArgs e) {
			this.Close();
		}

		private void MenuRandomize_Click(object sender, System.EventArgs e) {
			DrawRandomBars();
		}

		private void MenuSelection_Click(object sender, System.EventArgs e) {
			SelectionSort(Rectangles, GetCompareProc(CheckBoxAscending.Checked));
			ConditionalInvalidate();
		}

		private void MenuBubble_Click(object sender, System.EventArgs e) {
			BubbleSort(Rectangles, GetCompareProc(CheckBoxAscending.Checked));
			ConditionalInvalidate();
		}

		private void menuQuick_Click(object sender, System.EventArgs e) {
			QuickSort(Rectangles, Rectangles.GetLowerBound(0), Rectangles.GetUpperBound(0), GetCompareProc(CheckBoxAscending.Checked == false), GetCompareProc(CheckBoxAscending.Checked));
			ConditionalInvalidate();
		}



	}
}
