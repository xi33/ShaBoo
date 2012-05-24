using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaBoo.EFRepositories.Moqs
{
    using Moq;

    using ShaBoo.Domain.Repositories;
    using ShaBoo.Entities;

    public static class MoqSndClassRepository
    {
        public static ISndClassRepository Load()
        {
            var mock = new Mock<ISndClassRepository>();
            var du = 0;
            mock.Setup(m => m.GetAll()).Returns(new List<SndClass>
                                                  {
                                                      new SndClass(){ID=1, Name = "矿业学院", FstClassID = 1}, 
                                                      new SndClass(){ID=2,Name = "安全学院", FstClassID = 1}, 
                                                      new SndClass(){ID=3,Name = "力建学院", FstClassID = 1}, 
                                                      new SndClass(){ID=4,Name = "机电学院", FstClassID = 1}, 
                                                      new SndClass(){ID=5,Name = "信电学院", FstClassID = 1}, 
                                                      new SndClass(){ID=6,Name = "资源学院", FstClassID = 1}, 
                                                      new SndClass(){ID=7,Name = "化工学院", FstClassID = 1}, 
                                                      new SndClass(){ID=8,Name = "管理学院", FstClassID = 1}, 
                                                      new SndClass(){ID=9,Name = "环测学院", FstClassID = 1}, 
                                                      new SndClass(){ID=10,Name = "电力学院", FstClassID = 1}, 
                                                      new SndClass(){ID=11,Name = "文法学院", FstClassID = 1}, 
                                                      new SndClass(){ID=12,Name = "理学院", FstClassID = 1}, 
                                                      new SndClass(){ID=13,Name = "计算机学院", FstClassID = 1}, 
                                                      new SndClass(){ID=14,Name = "马克思主义学院", FstClassID = 1}, 
                                                      new SndClass(){ID=15,Name = "材料学院", FstClassID = 1}, 
                                                      new SndClass(){ID=16,Name = "外文学院", FstClassID = 1}, 
                                                      new SndClass(){ID=17,Name = "体育学院", FstClassID = 1}, 
                                                      new SndClass(){ID=18,Name = "艺术学院", FstClassID = 1}, 
                                                      new SndClass(){ID=19,Name = "孙越崎学院", FstClassID = 1}, 
                                                      new SndClass(){ID=20,Name = "国际学院", FstClassID = 1}, 
                                                      new SndClass(){ID=21,Name = "应用学院", FstClassID = 1}, 
                                                      
                                                      new SndClass(){ID=22,Name = "PPT模板", FstClassID = 2}, 
                                                      new SndClass(){ID=23,Name = "上网教程 ", FstClassID = 2}, 
                                                      new SndClass(){ID=24,Name = "IT技巧入门", FstClassID = 2}, 

                                                      new SndClass(){ID=21,Name = "四格漫画", FstClassID = 3}, 
                                                      new SndClass(){ID=21,Name = "游戏攻略", FstClassID = 3}, 
                                                      new SndClass(){ID=21,Name = "笑话锦囊", FstClassID = 3}, 

                                                  }.AsQueryable());
            return mock.Object;
        }
    }
}
