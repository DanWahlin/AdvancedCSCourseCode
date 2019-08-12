namespace UsingNInject
{
    public class Report
    {
        private readonly IPrinter _Printer;

        public Report(IPrinter printer)
        {
            _Printer = printer;
        }

        public bool Print()
        {
            if (_Printer != null) return _Printer.Print();
            else return false;
        }
    }
}