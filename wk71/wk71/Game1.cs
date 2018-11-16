using Microsoft.Xna.Framework;
using Nez;

namespace wk71
{
    public class Game1:Core
    {
        public Game1() : base(400 * 2, 300 * 2, isFullScreen: false, enableEntitySystems: true, windowTitle: "HELLO WORLD")
        {
            IsMouseVisible = true;
            Window.AllowUserResizing = true;
            Window.Position = new Point(0, 0);
            exitOnEscapeKeypress = false;
            //TargetElapsedTime = TimeSpan.FromTicks(333333);
            //IsFixedTimeStep = true;
            //TargetElapsedTime = TimeSpan.FromMilliseconds(1000.0f / 60);
        }

        protected override void Initialize()
        {
            base.Initialize();

            Scene.setDefaultDesignResolution(400, 300, Scene.SceneResolutionPolicy.FixedWidthPixelPerfect);
            //Debug.log(GetAspectRatio(400, 300));
            //Screen.setSize(400, 300);
            gameManager.Instance.Initialize();
            //gameManager.Instance.Initialize();
        }

        public Vector2 GetAspectRatio(int x, int y)
        {
            float f = (float)x / (float)y;
            int i = 0;
            while (true)
            {
                i++;
                if (System.Math.Round(f * i, 2) == Nez.Mathf.roundToInt(f * i))
                    break;
            }
            return new Vector2((float)System.Math.Round(f * i, 2), i);
        }
    }
}
