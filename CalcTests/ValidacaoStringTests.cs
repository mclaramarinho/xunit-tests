using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calc.Services;
namespace CalcTests
{

    public class ValidacaoStringTests
    {
        private ValidacaoString _vs;

        public ValidacaoStringTests(){
            _vs = new ValidacaoString();
        }

        [Fact]
        public void DeveContarCorretamente(){
            string texto = "Hello World";

            int res = _vs.ContarCaracteres(texto);

            Assert.Equal(11, res);
        }
        
    }
}