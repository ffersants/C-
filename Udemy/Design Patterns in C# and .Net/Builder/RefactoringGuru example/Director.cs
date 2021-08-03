using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGuru_example
{
    class Director
    {
        private IBuilder _builder;

        public IBuilder Biulder
        {
            set
            {
                _builder = value;
            }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
