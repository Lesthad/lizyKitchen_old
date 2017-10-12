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

                    "Arroz verde integral: el arroz ponerlo sobre un sart�n con aceite de oliva, ya que este agarrando color, invertir agua mezclada antes en la licuadora con Chile poblano, cilantro consom� de pollo y ajo. Dejar que se evapore el agua para que se cosa el arroz integral." +

                    "Salsa verde: tomate fresadilla, Chile Serrano, ajo, un poco de agua (esta salsa se sirve sobre el taco, dej�ndolo completamente ba�ado, si tu dieta de lo permite puedes agregarle un poco de queso)",
                    URLPhoto = "https://scontent-ort2-1.xx.fbcdn.net/v/t1.0-9/13659215_10153520972257493_3038451847717449966_n.jpg?oh=ed60d319a563b51dd6f3de761112b4d8&oe=5A43EE09"
                },
                new Recipe
                {
                    Title = "Salm�n en plancha de champi��n",
                    ShortDescription = "Salm�n en plancha de champi��n",
                    LongDescription = "Salm�n: calentar champi�ones y ponerlos sobre un plato, mientras dorar un filete de salmo con poco aceite de oliva extra virgen, ya que este listo, lo podr�s sobre los champi�ones" +

                  "Salsa: invertir en una licuadora jugo de lim�n,            aceite de oliva extra virgen,consom� de pollo, Chile de �rbol.Luego lo colocaras en un sart�n caliente con mantequilla dejando que vaya quedando un poco espesa la salsa" +

                  "Tomate cherry: los calentaras sobre un sart�n directamente Ejotes: en un sart�n agregas solo poco aceite de oliva extra virgen, luego pones los ejotes cortados en trozos y los cubres con un poco de sal de mar y cuadritos de ajo",
                    URLPhoto = "https://scontent-ort2-1.xx.fbcdn.net/v/t1.0-9/13606835_10153520972202493_3650545144034013137_n.jpg?oh=ee93dbbadf5b38e036a3237c5018441c&oe=5A430591"
                },
                new Recipe
                {
                    Title = "Ensalada y pollo",
                    ShortDescription = "Ensalada: agregas lechuga, tomate cherry,pepino y queso parmesano ",
                    LongDescription = "Milanesa de pechuga de pollo: en un sart�n agregas solo poco aceite de oliva extra virgen, luego pones los ejotes cortados en trozos, cuando est�n listos los pones en un plato. Mientras pones a calentar el pollo en un sart�n, sazonandolo con las especies que m�s te gusten. Al terminar lo pones sobre los ejotes",
                    URLPhoto = "https://scontent-ort2-2.xx.fbcdn.net/v/t1.0-9/13654134_10153520972267493_589449421182828218_n.jpg?oh=0808b5fed054d2613c09ba98f2c4957b&oe=5A551236"
                },
                new Recipe
                {
                    Title = "Pollo con ejotes",
                    ShortDescription = "Pollo con ejotes",
                    LongDescription = "Ejotes: en un sart�n agregas solo poco aceite de oliva extra virgen, luego pones los ejotes cortados en trozos y los cubres con un poco de sal de mar y cuadritos de ajo. Milanesa de pechuga de pollo: en un sart�n pones a calentar el pollo, sazonandolo con las especies que m�s te gusten. Tomate cherry: los calentaras sobre un sart�n directamente, luego los agregas sobre el pollo en el plato",
                    URLPhoto = "https://scontent-ort2-2.xx.fbcdn.net/v/t1.0-9/13606934_10153520972277493_213729117815166619_n.jpg?oh=b2bc453e5123547fca02990f0d54190c&oe=5A422599"
                },
                new Recipe
                {
                    Title = "Tacos de pollo",
                    ShortDescription = "Tacos de pollo",
                    LongDescription = "En una hoja de lechuga le agregas pollo cocido, pico de gallo (Chile, tomate,cebolla) y col morada. Si gustas puedes a�adirle lim�n, sal y una salsa",
                    URLPhoto = "https://scontent-ort2-2.xx.fbcdn.net/v/t1.0-9/13680664_10153520972432493_4671033888458188267_n.jpg?oh=16d41b5487d4da003a56a46a636d082c&oe=5A58EDAE"
                });
        }
    }
}
