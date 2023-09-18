using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joltzis {
    public class Block {
        
        public int Id;

        public int Width;
        public int Height;
        public int[,] Dots;

        private int[,] backupDots;

        public void Rotate() {
            // back the dots values into backup dots
            // so that it can be simply used for rolling back
            backupDots = Dots;

            Dots = new int[Width, Height];

            for (int i = 0; i < Width; i++) {
                for (int j = 0; j < Height; j++) {
                    Dots[i, j] = backupDots[Height - 1 - j, i];
                }
            }

            var temp = Width;
            Width = Height;
            Height = temp;
        }

        // the rolling back occurs when player rotating the shape
        // but it will touch other shapes and needs to be rolled back
        public void Rollback() {
            Dots = backupDots;

            var temp = Width;
            Width = Height;
            Height = temp;
        }

        public string selectColor(int id) {
            switch (id) {
                case (1):
                    return "#FF66C4";
                    break;
                case (2):
                    return "#6CD83E";
                    break;
                case (3):
                    return "#FFDE59";
                    break;
                case (4):
                    return "#5271FF";
                    break;
                case (5):
                    return "#0097B2";
                    break;
                case (6):
                    return "#FF3131";
                    break;
                case (7):
                    return "#FF914D";
                    break;
                default:
                    return "";
            }
        }
    }
}
