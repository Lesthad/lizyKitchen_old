namespace lizykitchen.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<lizykitchen.Models.lizykitchenDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "lizykitchen.Models.lizykitchenDB";
        }

        protected override void Seed(lizykitchen.Models.lizykitchenDB context)
        {
            context.Recipes.AddOrUpdate(r => r.Title,
                new Recipe { Title = "Enchiladas Suizas Light",
                    ShortDescription = "Tacos de pollo envueltos en hoja de lechuga",
                    LongDescription = "Frijoles rojos: hervir frijoles en agua, ajo y sal de mar (solo poca)." +

                    "Arroz verde integral: el arroz ponerlo sobre un sartén con aceite de oliva, ya que este agarrando color, invertir agua mezclada antes en la licuadora con Chile poblano, cilantro consomé de pollo y ajo. Dejar que se evapore el agua para que se cosa el arroz integral." +

                    "Salsa verde: tomate fresadilla, Chile Serrano, ajo, un poco de agua (esta salsa se sirve sobre el taco, dejándolo completamente bañado, si tu dieta de lo permite puedes agregarle un poco de queso)",
                    URLPhoto = "https://scontent-ort2-1.xx.fbcdn.net/v/t1.0-9/13659215_10153520972257493_3038451847717449966_n.jpg?oh=ed60d319a563b51dd6f3de761112b4d8&oe=5A43EE09"
                },
                new Recipe
                {
                    Title = "Salmón en plancha de champiñón",
                    ShortDescription = "Salmón en plancha de champiñón",
                    LongDescription = "Salmón: calentar champiñones y ponerlos sobre un plato, mientras dorar un filete de salmo con poco aceite de oliva extra virgen, ya que este listo, lo podrás sobre los champiñones" +

                  "Salsa: invertir en una licuadora jugo de limón,            aceite de oliva extra virgen,consomé de pollo, Chile de árbol.Luego lo colocaras en un sartén caliente con mantequilla dejando que vaya quedando un poco espesa la salsa" +

                  "Tomate cherry: los calentaras sobre un sartén directamente Ejotes: en un sartén agregas solo poco aceite de oliva extra virgen, luego pones los ejotes cortados en trozos y los cubres con un poco de sal de mar y cuadritos de ajo",
                    URLPhoto = "https://scontent-ort2-1.xx.fbcdn.net/v/t1.0-9/13606835_10153520972202493_3650545144034013137_n.jpg?oh=ee93dbbadf5b38e036a3237c5018441c&oe=5A430591"
                },
                new Recipe
                {
                    Title = "Ensalada y pollo",
                    ShortDescription = "Ensalada: agregas lechuga, tomate cherry,pepino y queso parmesano ",
                    LongDescription = "Milanesa de pechuga de pollo: en un sartén agregas solo poco aceite de oliva extra virgen, luego pones los ejotes cortados en trozos, cuando estén listos los pones en un plato. Mientras pones a calentar el pollo en un sartén, sazonandolo con las especies que más te gusten. Al terminar lo pones sobre los ejotes",
                    URLPhoto = "https://scontent-ort2-2.xx.fbcdn.net/v/t1.0-9/13654134_10153520972267493_589449421182828218_n.jpg?oh=0808b5fed054d2613c09ba98f2c4957b&oe=5A551236"
                },
                new Recipe
                {
                    Title = "Pollo con ejotes",
                    ShortDescription = "Pollo con ejotes",
                    LongDescription = "Ejotes: en un sartén agregas solo poco aceite de oliva extra virgen, luego pones los ejotes cortados en trozos y los cubres con un poco de sal de mar y cuadritos de ajo. Milanesa de pechuga de pollo: en un sartén pones a calentar el pollo, sazonandolo con las especies que más te gusten. Tomate cherry: los calentaras sobre un sartén directamente, luego los agregas sobre el pollo en el plato",
                    URLPhoto = "https://scontent-ort2-2.xx.fbcdn.net/v/t1.0-9/13606934_10153520972277493_213729117815166619_n.jpg?oh=b2bc453e5123547fca02990f0d54190c&oe=5A422599"
                },
                new Recipe
                {
                    Title = "Tacos de pollo",
                    ShortDescription = "Tacos de pollo",
                    LongDescription = "En una hoja de lechuga le agregas pollo cocido, pico de gallo (Chile, tomate,cebolla) y col morada. Si gustas puedes añadirle limón, sal y una salsa",
                    URLPhoto = "https://scontent-ort2-2.xx.fbcdn.net/v/t1.0-9/13680664_10153520972432493_4671033888458188267_n.jpg?oh=16d41b5487d4da003a56a46a636d082c&oe=5A58EDAE"
                });
        }
    }
}
