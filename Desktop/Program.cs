using HotTask;

namespace Desktop {
    public class Program {

        public static void Main() {
            using (var game = new GameImpl())
                game.Run();
        }

    }
}