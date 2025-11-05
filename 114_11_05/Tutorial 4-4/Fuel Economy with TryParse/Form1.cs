using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    /// <summary>
    /// 主表單：處理使用者輸入並計算油耗（Fuel Economy）。
    /// 目前計算按鈕的事件處理函式尚未實作，請在 calculateButton_Click 內加入使用 TryParse 的輸入解析與計算邏輯。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構式：初始化表單與其控制項（由 Designer 產生的 InitializeComponent）。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算按鈕事件：
        /// - 此處應讀取使用者在表單上輸入的數值（例如里程與油量）。
        /// - 使用 Double.TryParse 或 Decimal.TryParse 等安全解析方法來避免例外。
        /// - 驗證解析成功後進行油耗計算並顯示結果（例如在 Label 或 TextBox）。
        /// - 若解析失敗，應提示使用者修正輸入（例如 MessageBox 或標示錯誤）。
        /// 範例流程（意義說明，請在此處實作實際程式碼）：
        ///  1. var success = double.TryParse(milesTextBox.Text, out double miles);
        ///  2. var success2 = double.TryParse(gallonsTextBox.Text, out double gallons);
        ///  3. if (success && success2) { var mpg = miles / gallons; /* 顯示 mpg */ }
        ///  4. else { /* 顯示輸入錯誤的訊息 */ }
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入的里程和油量
            bool isMilesValid = double.TryParse(milesTextBox.Text, out double miles);
            bool isGallonsValid = double.TryParse(gallonsTextBox.Text, out double gallons);

            // 驗證輸入並計算油耗
            if (isMilesValid && isGallonsValid && gallons > 0)
            {
                double mpg = miles / gallons;
                resultLabel.Text = $"油耗：{mpg:F2} 英里/加侖";
            }
            else
            {
                MessageBox.Show("請確認輸入的里程和油量是否為有效的正數字值。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 離開按鈕事件：關閉表單並結束應用程式（如果這是主要視窗）。
        /// this.Close() 會觸發表單關閉與相應的清除程序。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
