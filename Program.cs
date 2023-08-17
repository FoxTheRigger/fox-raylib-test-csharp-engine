using Raylib_cs;
using System.Numerics;

namespace Test  {

    static class Program {

        const int scrWidth = 900;
        const int scrHeight = 350;

        public static void Main() {
            Raylib.InitWindow(scrWidth, scrHeight, "Test 2D Raylib Engine Game");

            Vector2 circlePOS = new Vector2((float)scrWidth / 2, (float)scrHeight / 2);
            Raylib.SetTargetFPS(60);
            while (!Raylib.WindowShouldClose())  {
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) circlePOS.X += 2.0f;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) circlePOS.X -= 2.0f;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) circlePOS.Y -= 2.0f;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) circlePOS.Y += 2.0f;

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
                Raylib.DrawText("Test", 10, 10, 20, Color.ORANGE);
                Raylib.DrawCircleV(circlePOS, 50, Color.PURPLE);
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}