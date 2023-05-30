using Primavera.Extensibility.Base.Editors;
using BasBE100;
using StdBE100;
using Primavera.Extensibility.CustomTab;
using System;

namespace ExtensibilityProject2
{
    public partial class PriCustomTab : CustomTab<FichaClientes>
    {
        public PriCustomTab()
        {
            InitializeComponent();
        }

        private void PriCustomTab1_Loading()
        {
            BasBECliente cliente = this.ContextService.Cliente;

            StdBECampos cdu = cliente.CamposUtil;

            tb_cv1.Text = Convert.ToString(cdu["CDU_CampoVar1"].Valor);
            tb_cv2.Text = Convert.ToString(cdu["CDU_CampoVar2"].Valor);
            tb_cv3.Text = Convert.ToString(cdu["CDU_CampoVar3"].Valor);
        }

        private void PriCustomTab1_Saving()
        {
            BasBECliente cliente = this.ContextService.Cliente;

            cliente.CamposUtil["CDU_CampoVar1"].Valor = tb_cv1.Text;
            cliente.CamposUtil["CDU_CampoVar2"].Valor = tb_cv2.Text;
            cliente.CamposUtil["CDU_CampoVar3"].Valor = tb_cv3.Text;
        }
    }
}
