using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Nez;

namespace wk71.src.Scenes
{
    class titleScene : Scene
    {

        public override void initialize()
        {
            base.initialize();
            clearColor = new Color(255, 225, 230, 100);
            addRenderer(new DefaultRenderer());


        }
    }
}
