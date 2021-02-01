using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mathematica;

namespace MathematicaImplementacion
{
    public partial class MathematicaForm : Form
    {
        double memory = 0, lastNumber = 0;
        double[] vectorR;
        bool finished = false;
        Func<double, double, double> lastAction;

        public MathematicaForm()
        {
            InitializeComponent();
        }

        private bool checkContent()
        {
            if (txtInput.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Trigonometry.GetSin(inputNumber).ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Trigonometry.GetCos(inputNumber).ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Trigonometry.GetTan(inputNumber).ToString();
            }
        }

        private void btnCsc_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Trigonometry.GetCsc(inputNumber).ToString();
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Trigonometry.GetSec(inputNumber).ToString();
            }
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Trigonometry.GetCot(inputNumber).ToString();
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.ElevateToPower(inputNumber, 2).ToString();
            }
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.ElevateToPower(inputNumber, 3).ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.GetRootValue(inputNumber, 2).ToString();
            }
        }

        private void btnCbrt_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.GetRootValue(inputNumber, 3).ToString();
            }
        }

        private void btnEtoPower_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.ElevateToPower(Constants.e, (int)Arithmetic.RoundNumber(inputNumber)).ToString();
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtInput.Text = Constants.e.ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.GetLogNatural(inputNumber).ToString();
            }
        }

        private void btnLog10_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.GetLog(inputNumber, 10).ToString();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtInput.Text = Constants.PI.ToString();
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.GetAbsoluteValue(inputNumber).ToString();
            }
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.GetFactorial((int)Arithmetic.RoundNumber(inputNumber)).ToString();
            }
        }

        private void btnSgn_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.GetSignOfNumber(inputNumber).ToString();
            }
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.GetFloorValue(inputNumber).ToString();
            }
        }

        private void btnCeil_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.GetCeilingValue(inputNumber).ToString();
            }
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                txtInput.Text = Arithmetic.RoundNumber(inputNumber).ToString();
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (finished)
            {
                finished = false;
                txtInput.Text = "";
            }
            txtInput.Text += ((Button)sender).Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtInput.Text.Contains("."))
            {
                txtInput.Text += ((Button)sender).Text;
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtInput.Text = memory.ToString();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                memory = inputNumber;
            }
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                memory += inputNumber;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length-1);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                DoLastOperation(inputNumber);
                lastAction = Arithmetic.DivideTwoDecimalNumbers;
                lblOperationStack.Text += inputNumber.ToString() + "/";
                txtInput.Text = "";
            }
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            lblOperationStack.Text = "";
            lastNumber = 0;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                DoLastOperation(inputNumber);
                lastAction = Arithmetic.MultiplyTwoDecimalNumbers;
                lblOperationStack.Text += inputNumber.ToString() + "*";
                txtInput.Text = "";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                DoLastOperation(inputNumber);
                lastAction = Arithmetic.SubtractTwoDecimalNumbers;
                lblOperationStack.Text += inputNumber.ToString() + "-";
                txtInput.Text = "";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                DoLastOperation(inputNumber);
                lastAction = Arithmetic.AddTwoDecimalNumbers;
                lblOperationStack.Text += inputNumber.ToString() + "+";
                txtInput.Text = "";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                DoLastOperation(inputNumber);
                lastAction = null;
                finished = true;
                txtInput.Text = lastNumber.ToString();
                lblOperationStack.Text = "";
            }
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            txtInput.Text = lastNumber.ToString();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                DoLastOperation(inputNumber);
                lastAction = Arithmetic.ElevateToPower;
                lblOperationStack.Text += inputNumber.ToString() + "^";
                txtInput.Text = "";
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                DoLastOperation(inputNumber);
                lastAction = Arithmetic.GetRootValue;
                lblOperationStack.Text += inputNumber.ToString() + "√";
                txtInput.Text = "";
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                double inputNumber = Convert.ToDouble(txtInput.Text);
                DoLastOperation(inputNumber);
                lastAction = Arithmetic.GetLog;
                lblOperationStack.Text += "log"+inputNumber.ToString()+" ";
                txtInput.Text = "";
            }
        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtVolumen.Text = "";
            lblData1.Visible = false;
            lblData2.Visible = false;
            lblData3.Visible = false;
            lblData4.Visible = false;
            numData1.Visible = false;
            numData2.Visible = false;
            numData3.Visible = false;
            numData4.Visible = false;
            switch (cmbFigura.SelectedIndex)
            {
                case 0:
                case 8:
                    lblData1.Visible = true;
                    lblData1.Text = "Lado";
                    numData1.Visible = true;
                    break;
                case 1:
                case 3:
                case 5:
                    lblData1.Visible = true;
                    lblData1.Text = "Base";
                    numData1.Visible = true;
                    lblData2.Visible = true;
                    lblData2.Text = "Altura";
                    numData2.Visible = true;
                    break;
                case 2:
                case 9:
                    lblData1.Visible = true;
                    lblData1.Text = "Radio";
                    numData1.Visible = true;
                    break;
                case 4:
                    lblData1.Visible = true;
                    lblData1.Text = "Diagonal Mayor";
                    numData1.Visible = true;
                    lblData2.Visible = true;
                    lblData2.Text = "Diagonal Menor";
                    numData2.Visible = true;
                    break;
                case 6:
                    lblData1.Visible = true;
                    lblData1.Text = "Base Mayor";
                    numData1.Visible = true;
                    lblData2.Visible = true;
                    lblData2.Text = "Base Menor";
                    numData2.Visible = true;
                    lblData3.Visible = true;
                    lblData3.Text = "Altura";
                    numData3.Visible = true;
                    break;
                case 7:
                    lblData1.Visible = true;
                    lblData1.Text = "Número de Lados";
                    numData1.Visible = true;
                    lblData2.Visible = true;
                    lblData2.Text = "Longitud de Lado";
                    numData2.Visible = true;
                    lblData3.Visible = true;
                    lblData3.Text = "Apotema";
                    numData3.Visible = true;
                    break;
                case 10:
                case 12:
                    lblData1.Visible = true;
                    lblData1.Text = "Número de Lados";
                    numData1.Visible = true;
                    lblData2.Visible = true;
                    lblData2.Text = "Longitud de Lado";
                    numData2.Visible = true;
                    lblData3.Visible = true;
                    lblData3.Text = "Apotema";
                    numData3.Visible = true;
                    lblData4.Visible = true;
                    lblData4.Text = "Altura";
                    numData4.Visible = true;
                    break;
                case 11:
                case 13:
                    lblData1.Visible = true;
                    lblData1.Text = "Radio de base";
                    numData1.Visible = true;
                    lblData2.Visible = true;
                    lblData2.Text = "Altura";
                    numData2.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void numData_ValueChanged(object sender, EventArgs e)
        {
            switch (cmbFigura.SelectedIndex)
            {
                case 0:
                    txtPerimeter.Text = Perimeter.GetSquarePerimeter((double)numData1.Value).ToString();
                    txtArea.Text = Area.GetSquareArea((double)numData1.Value).ToString();
                    break;
                case 1:
                    txtArea.Text = Area.GetTriangleArea((double)numData1.Value, (double)numData2.Value).ToString();
                    break;
                case 2:
                    txtPerimeter.Text = Perimeter.GetCirclePerimeter((double)numData1.Value).ToString();
                    txtArea.Text = Area.GetCircleArea((double)numData1.Value).ToString();
                    break;
                case 3:
                    txtArea.Text = Area.GetParallelogramArea((double)numData1.Value, (double)numData2.Value).ToString();
                    txtPerimeter.Text = Perimeter.GetParalelogramPerimeter((double)numData1.Value, (double)numData2.Value).ToString();
                    break;
                case 4:
                    txtArea.Text = Area.GetRhombusArea((double)numData1.Value, (double)numData2.Value).ToString();
                    break;
                case 5:
                    txtArea.Text = Area.GetParallelogramArea((double)numData1.Value, (double)numData2.Value).ToString();
                    break;
                case 6:
                    txtArea.Text = Area.GetTrapezoidArea((double)numData1.Value, (double)numData2.Value, (double)numData3.Value).ToString();
                    break;
                case 7:
                    txtPerimeter.Text = Perimeter.GetRegularPolygonPerimeter((int)numData1.Value, (double)numData2.Value).ToString();
                    txtArea.Text = Area.GetRegularPolygonArea((int)numData1.Value, (double)numData2.Value, (double)numData3.Value).ToString();
                    break;
                case 8:
                    txtArea.Text = Area.GetCubeArea((double)numData1.Value).ToString();
                    txtVolumen.Text = Volume.GetCubeVolume((double)numData1.Value).ToString();
                    break;
                case 9:
                    txtVolumen.Text = Volume.GetSphereVolume((double)numData1.Value).ToString();
                    break;
                case 10:
                    txtVolumen.Text = Volume.GetPrismVolume((int)numData1.Value, (double)numData2.Value, (double)numData3.Value, (double)numData4.Value).ToString();
                    break;
                case 11:
                    txtVolumen.Text = Volume.GetCylinderVolume((double)numData1.Value, (double)numData2.Value).ToString();
                    break;
                case 12:
                    txtVolumen.Text = Volume.GetPyramidVolume((int)numData1.Value, (double)numData2.Value, (double)numData3.Value, (double)numData4.Value).ToString();
                    break;
                case 13:
                    txtVolumen.Text = Volume.GetConeVolume((double)numData1.Value, (double)numData2.Value).ToString();
                    break;
                default:
                    break;
            }
        }

        private void txtGeom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x1 = Convert.ToDouble(txtX1.Text);
                double x2 = Convert.ToDouble(txtX2.Text);
                double y1 = Convert.ToDouble(txtY1.Text);
                double y2 = Convert.ToDouble(txtY2.Text);
                double ratio = Convert.ToDouble(txtRazon.Text);
                txtDistance.Text = AnalyticGeometry.GetDistanceBetweenTwoPoints(x1, y1, x2, y2).ToString();
                double[] middlePoint = AnalyticGeometry.GetMiddlePoint(x1, y1, x2, y2);
                txtMiddle.Text = middlePoint[0] + ", " + middlePoint[1];
                txtSlope.Text = AnalyticGeometry.GetSlope(x1, y1, x2, y2).ToString();
                double[] ratioPoint = AnalyticGeometry.GetPointInRatio(x1, y1, x2, y2, ratio);
                txtRatioPoint.Text = ratioPoint[0] + ", " + ratioPoint[1];
            }
            catch
            {

            }
            
        }

        private void dgvDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double[] data = new double[dgvDatos.RowCount];
                for (int i = 0; i < dgvDatos.RowCount; i++)
                {
                    data[i] = Convert.ToDouble(dgvDatos[0, i].Value);
                }
                txtPromedio.Text = Statistic.GetAverage(data).ToString();
                txtMediana.Text = Statistic.GetMedian(data).ToString();
                txtModa.Text = Statistic.GetMode(data).ToString();
            }
            catch { }
        }

        private void btnAddVector_Click(object sender, EventArgs e)
        {
            double[] vectorA = {(double)numXa.Value, (double)numYa.Value, (double)numZa.Value };
            double[] vectorB = { (double)numXb.Value, (double)numYb.Value, (double)numZb.Value };
            vectorR = Vectorial.AddTwoVectors(vectorA, vectorB);
            txtVectorResultado.Text = vectorR[0] + ", " + vectorR[1] + ", " + vectorR[2];
        }

        private void btnMinusVector_Click(object sender, EventArgs e)
        {
            double[] vectorA = { (double)numXa.Value, (double)numYa.Value, (double)numZa.Value };
            double[] vectorB = { (double)numXb.Value, (double)numYb.Value, (double)numZb.Value };
            vectorR = Vectorial.SubstractTwoVectors(vectorA, vectorB);
            txtVectorResultado.Text = vectorR[0] + ", " + vectorR[1] + ", " + vectorR[2];
        }

        private void btnDotProduct_Click(object sender, EventArgs e)
        {
            double[] vectorA = { (double)numXa.Value, (double)numYa.Value, (double)numZa.Value };
            double[] vectorB = { (double)numXb.Value, (double)numYb.Value, (double)numZb.Value };
            double dotProduct = Vectorial.GetDotProduct(vectorA, vectorB);
            txtVectorResultado.Text = dotProduct.ToString();
        }

        private void btnCrossProduct_Click(object sender, EventArgs e)
        {
            double[] vectorA = { (double)numXa.Value, (double)numYa.Value, (double)numZa.Value };
            double[] vectorB = { (double)numXb.Value, (double)numYb.Value, (double)numZb.Value };
            vectorR = Vectorial.GetCrossProduct(vectorA, vectorB);
            txtVectorResultado.Text = vectorR[0] + ", " + vectorR[1] + ", " + vectorR[2];
        }

        private void btnMagnitud_Click(object sender, EventArgs e)
        {
            txtVectorResultado.Text = Vectorial.GetMagnitude(vectorR).ToString();
        }

        private void btnUnitario_Click(object sender, EventArgs e)
        {
            double[] unitVector = Vectorial.GetUnitVector(vectorR);
            txtVectorResultado.Text = unitVector[0] + ", " + unitVector[1] + ", " + unitVector[2];
        }

        private void numM_ValueChanged(object sender, EventArgs e)
        {
            double[,] matrix = { {(double)numM11.Value, (double)numM12.Value, (double)numM13.Value },
                                    {(double)numM21.Value, (double)numM22.Value, (double)numM23.Value },
                                    {(double)numM31.Value, (double)numM32.Value, (double)numM33.Value }};
            txtDeterminant.Text = LinearAlgebra.GetDeterminant(matrix).ToString();
        }

        private void DoLastOperation(double number)
        {
            if (lastAction == null)
            {
                lastNumber = number;
                return;
            }
            lastNumber = lastAction(lastNumber, number);
        }
    }

}
