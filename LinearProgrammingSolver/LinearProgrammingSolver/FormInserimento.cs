﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearProgrammingSolver
{
    public partial class FormInserimento : Form
    {
        public FormInserimento()
        {
            InitializeComponent();
        }

        private void FormInserimento_Load(object sender, EventArgs e)
        {
            /*LinearProgrammingProblem lp = new LinearProgrammingProblem(
                new Equation(new decimal[] { 5, 10, 8 }), 
                true, 
                new Inequality[] { new Inequality(new decimal[] { 3, 5, 2 }, InequalitySign.GreaterThanOrEqual, 60m),
                                   new Inequality(new decimal[] { 4, 4, 4 }, InequalitySign.GreaterThanOrEqual, 72m),
                                   new Inequality(new decimal[] { 2, 4, 5 }, InequalitySign.GreaterThanOrEqual, 100)
                                 },
                3, 
                3);
            
            Console.WriteLine(lp);*/

            /*Equation eq = new Equation(new decimal[] { 5, 10, 8 }, 2);
            Console.WriteLine(eq);
            eq.InvertSigns();
            Console.WriteLine(eq);*/

            Inequality eq = new Inequality(new decimal[] { 3, 5, 2 }, InequalitySign.GreaterThanOrEqual, 60m);
            Console.WriteLine(eq);
            eq.InvertSigns();
            Console.WriteLine(eq);
        }
    }
}
