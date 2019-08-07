/*Author:Matthew Powers
 * Date: 6/8/17
 * class: C# programming
 * Description: Adds, multiplies, subtracts, and divides fractions
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSI_154_Exercise_07
{
    public partial class frmExercise7 : Form
    {
        public frmExercise7()
        {
            InitializeComponent();
        }

        struct Rational
        {
            // Fields
            private int _numerator;
            private int _denominator;

            // getters and setters
            public Rational(int Numerator, int Denominator)
            {
                _numerator = Numerator;
                _denominator = Denominator;
            }

            public int Numerator
            {
                get { return _numerator; }
                set { _numerator = value; }
            }

            public int Denominator
            {
                get { return _denominator; }
                set { _denominator = value; }
            }

            // methods
            public Rational AddRational(int numer1, int denom1, int numer2, int denom2)
            {
                if (denom1 != denom2)
                {
                    int tempNum = denom1 * denom2;
                    numer1 = numer1 * denom2;
                    numer2 = numer2 * denom1;
                    denom1 = tempNum;
                    denom2 = tempNum;
                }
                this.Numerator = numer1 + numer2;
                this.Denominator = denom1;
                return new Rational((numer1 + numer2), denom1);
            }

            public Rational MinusRational(int numer1, int denom1, int numer2, int denom2)
            {
                if (denom1 != denom2)
                {
                    int tempNum = denom1 * denom2;
                    numer1 = numer1 * denom2;
                    numer2 = numer2 * denom1;
                    denom1 = tempNum;
                    denom2 = tempNum;
                }
                this.Numerator = numer1 - numer2;
                this.Denominator = denom1;
                return new Rational((numer1 - numer2), denom1);
            }

            public Rational MultiplyRational(int numer1, int denom1, int numer2, int denom2)
            {
                this.Numerator = numer1 * numer2;
                this.Denominator = denom1 * denom2;
                return new Rational((numer1 * numer2), denom1 * denom2);
            }

            public Rational DivideRational(int numer1, int denom1, int numer2, int denom2)
            {
                this.Numerator = numer1 * denom2;
                this.Denominator = denom1 * numer2;
                return new Rational((numer1 * denom2), denom1 * numer2);
            }

            public Rational GreatesCommonDenominator(int numer, int denom)
            {
                int larger = 0;
                int smaller = 0;
                int count = 0;
                if (numer > denom)
                {
                    larger = numer;
                    smaller = denom;
                }
                else if (denom > numer)
                {
                    larger = denom;
                    smaller = numer;
                }
                int[] numDenArray = new int[larger];
                for (int i = 1; i < larger; i++)
                {
                    if (larger % i == 0)
                    {
                        for (int j = 1; j < smaller; j++)
                        {
                            if (smaller % j == 0 && i == j)
                            {
                                numDenArray[count] = j;
                                count++;
                            }
                        }
                    }
                }
                this.Numerator = (numer / (numDenArray.Length - 1));
                this.Denominator = (denom / (numDenArray.Length - 1));
                return new Rational(Denominator, Numerator);
            }
        }

        private void btnAddFractions_Click(object sender, EventArgs e)
        {
            Rational sum = new Rational();
            sum.AddRational(int.Parse(rchtxtbxNumUno.Text), int.Parse(rchtxtbxDomUno.Text), int.Parse(rchtxtbxNumDos.Text), int.Parse(rchtxtbxDomDos.Text));

            rchtxtbxDomFinal.Text = sum.Denominator.ToString();
            rchtxtbxNumFinal.Text = sum.Numerator.ToString();
            sum.GreatesCommonDenominator(int.Parse(rchtxtbxDomUno.Text), int.Parse(rchtxtbxNumUno.Text));
            sum.GreatesCommonDenominator(int.Parse(rchtxtbxDomDos.Text), int.Parse(rchtxtbxNumDos.Text));
            sum.GreatesCommonDenominator(int.Parse(rchtxtbxDomFinal.Text), int.Parse(rchtxtbxNumFinal.Text));
        }

        private void btnSubtractFractions_Click(object sender, EventArgs e)
        {
            Rational reduce = new Rational();
            reduce.MinusRational(int.Parse(rchtxtbxNumUno.Text), int.Parse(rchtxtbxDomUno.Text), int.Parse(rchtxtbxNumDos.Text), int.Parse(rchtxtbxDomDos.Text));

            rchtxtbxDomFinal.Text = reduce.Denominator.ToString();
            rchtxtbxNumFinal.Text = reduce.Numerator.ToString();
            reduce.GreatesCommonDenominator(int.Parse(rchtxtbxDomUno.Text), int.Parse(rchtxtbxNumUno.Text));
            reduce.GreatesCommonDenominator(int.Parse(rchtxtbxDomDos.Text), int.Parse(rchtxtbxNumDos.Text));
            reduce.GreatesCommonDenominator(int.Parse(rchtxtbxDomFinal.Text), int.Parse(rchtxtbxNumFinal.Text));
        }

        private void btnMultiplyFractions_Click(object sender, EventArgs e)
        {
            Rational multi = new Rational();
            multi.MultiplyRational(int.Parse(rchtxtbxNumUno.Text), int.Parse(rchtxtbxDomUno.Text), int.Parse(rchtxtbxNumDos.Text), int.Parse(rchtxtbxDomDos.Text));

            rchtxtbxDomFinal.Text = multi.Denominator.ToString();
            rchtxtbxNumFinal.Text = multi.Numerator.ToString();
            multi.GreatesCommonDenominator(int.Parse(rchtxtbxDomUno.Text), int.Parse(rchtxtbxNumUno.Text));
            multi.GreatesCommonDenominator(int.Parse(rchtxtbxDomDos.Text), int.Parse(rchtxtbxNumDos.Text));
            multi.GreatesCommonDenominator(int.Parse(rchtxtbxDomFinal.Text), int.Parse(rchtxtbxNumFinal.Text));
        }

        private void btnDivideFractions_Click(object sender, EventArgs e)
        {
            Rational div = new Rational();
            div.DivideRational(int.Parse(rchtxtbxNumUno.Text), int.Parse(rchtxtbxDomUno.Text), int.Parse(rchtxtbxNumDos.Text), int.Parse(rchtxtbxDomDos.Text));

            rchtxtbxDomFinal.Text = div.Denominator.ToString();
            rchtxtbxNumFinal.Text = div.Numerator.ToString();
            div.GreatesCommonDenominator(int.Parse(rchtxtbxDomUno.Text), int.Parse(rchtxtbxNumUno.Text));
            div.GreatesCommonDenominator(int.Parse(rchtxtbxDomDos.Text), int.Parse(rchtxtbxNumDos.Text));
            div.GreatesCommonDenominator(int.Parse(rchtxtbxDomFinal.Text), int.Parse(rchtxtbxNumFinal.Text));
        }
    }
}
