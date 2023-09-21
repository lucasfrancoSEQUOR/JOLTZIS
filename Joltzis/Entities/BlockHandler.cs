using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joltzis {
    public class BlockHandler {
        public static Block[] shapesArray;

        static  BlockHandler() {
            
            shapesArray = new Block[]
                {
                    new Block {
                        Id = 1,
                        Width = 2,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 1, 1 },
                            { 1, 1 }
                        }
                    },
                    new Block {
                        Id = 2,
                        Width = 1,
                        Height = 4,
                        Dots = new int[,]
                        {
                            { 1 },
                            { 1 },
                            { 1 },
                            { 1 }
                        }
                    },
                    new Block {
                        Id = 3,
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 1, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Block {
                        Id = 4,
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 0, 1 },
                            { 1, 1, 1 }
                        }
                    },
                    new Block {
                        Id = 5,
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 1, 0, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Block {
                        Id = 6,
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 1, 1, 0 },
                            { 0, 1, 1 }
                        }
                    },
                    new Block {
                        Id = 7,
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 1, 1 },
                            { 1, 1, 0 }
                        }
                    }
                };
        }

        public static Block GetRandomShape() {

            var shape = shapesArray[new Random().Next(shapesArray.Length)];
            var backupShape = shape;

            while (shape == backupShape) {
                shape = shapesArray[new Random().Next(shapesArray.Length)];
            }

            return shape;
        }

    }
}
