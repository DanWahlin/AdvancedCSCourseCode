using System;

namespace Chapter2.StringBuilderDemo {
    public class UsingTheStringBuilder {
        public static void Main() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

			for (int i=0;i<=20;i++) {
				sb.Append("Number: ");
				sb.Append(i.ToString());
				sb.AppendLine();
			}
			Console.WriteLine(sb.ToString());

			Console.ReadLine();
        }
    }
}
