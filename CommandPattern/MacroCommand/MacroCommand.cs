using DesignPatterns.CommandPattern.Command;

namespace DesignPatterns.CommandPattern.MacroCommand
{
    // MacroCommand cho phép nhóm nhiều lệnh lại với nhau và thực thi chúng như một lệnh duy nhất.
    public class MacroCommand : ICommand
    {
        private readonly List<ICommand> _commands;
        private readonly string _macroName;

        public MacroCommand(string macroName, List<ICommand> commands)
        {
            _macroName = macroName;
            _commands = commands;
        }

        public void Execute()
        {
            Console.WriteLine($"\nMacro [{_macroName}] bắt đầu:");
            foreach (var cmd in _commands)
                cmd.Execute();
            Console.WriteLine($"Macro [{_macroName}] hoàn thành.");
        }

        public void Undo()
        {
            Console.WriteLine($"\nHuỷ Macro [{_macroName}]:");
            for (int i = _commands.Count - 1; i >= 0; i--)
                _commands[i].Undo();
        }
    }
}
