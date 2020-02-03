using ConsultorioDigital.BLL.Seguridad;
using ConsultorioDigital.Seguridad;
using ConsultorioDigital.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsultorioDigital.UI.Formularios
{
  public partial class FamiliaForm : Form
  {
    private PermisoBLL _permisoBLL = new PermisoBLL();
    private IDictionary<TreeNode, Permiso> _permisos = new Dictionary<TreeNode, Permiso>();
    private IDictionary<TreeNode, Permiso> _hijos;
    private Familia _familia;

    public FamiliaForm()
    {
      InitializeComponent();

      IEnumerable<Permiso> permisos = _permisoBLL.Todos();

      cboFamilias.DisplayMember = "Nombre";

      //cboFamilias.DataSource = null;
      //cboFamilias.DataSource = permisos.Where(x => x.GetType() == typeof(Familia)).ToList();
      cboFamilias.Items.AddRange(permisos.Where(x => x.GetType() == typeof(Familia)).ToArray());

      EnlazarTreeView(permisos);
    }

    private void EnlazarTreeView(IEnumerable<Permiso> permisos)
    {
      trePermisos.Nodes.Clear();
      _permisos.Clear();

      foreach (Permiso permiso in permisos)
      {
        TreeNode node = new TreeNode(permiso.Nombre);

        _permisos.Add(node, permiso);

        trePermisos.Nodes.Add(node);

        AgregarRecursivo(permiso, node, _permisos);
      }
    }

    private void AgregarRecursivo(Permiso permiso, TreeNode nodoPadre, IDictionary<TreeNode, Permiso> permisos)
    {
      foreach (Permiso hijo in permiso.Hijos)
      {
        TreeNode nodoHijo = new TreeNode(hijo.Nombre);

        nodoPadre.Nodes.Add(nodoHijo);

        AgregarRecursivo(hijo, nodoHijo, permisos);
      }
    }

    private void cboFamilias_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      treFamilia.Nodes.Clear();

      _hijos = new Dictionary<TreeNode, Permiso>();

      _familia = (Familia)cboFamilias.SelectedItem;

      foreach (Permiso permiso in _familia.Hijos)
      {
        TreeNode node = new TreeNode(permiso.Nombre);

        _hijos.Add(node, permiso);

        treFamilia.Nodes.Add(node);

        AgregarRecursivo(permiso, node, null);
      }
    }

    private void btnAgregar_Click(object sender, System.EventArgs e)
    {
      TreeNode nodo = trePermisos.SelectedNode;

      if (_familia == null)
      {
        MessageBoxHelper.ShowError("Debe seleccionar una familia");
        return;
      }

      if (nodo == null)
      {
        MessageBoxHelper.ShowError("Debe seleccionar una permiso");
        return;
      }

      if (!_permisos.ContainsKey(nodo))
      {
        MessageBoxHelper.ShowError("Debe seleccionar un nodo raiz");
        return;
      }

      Permiso hijo = _permisos[nodo];

      try
      {
        _permisoBLL.Agregar(_familia, hijo);

        TreeNode nodoHijo = new TreeNode(hijo.Nombre);        

        treFamilia.Nodes.Add(nodoHijo);

        AgregarRecursivo(hijo, nodoHijo, null);

        _hijos.Add(nodoHijo, hijo);

        EnlazarTreeView(_permisoBLL.Todos());
      }
      catch (Exception ex)
      {
        MessageBoxHelper.ShowError(ex.Message);
      }
    }

    private void btnRemover_Click(object sender, EventArgs e)
    {
      TreeNode nodo = treFamilia.SelectedNode;

      if (nodo == null)
      {
        MessageBoxHelper.ShowError("Debe seleccionar un permiso");
        return;
      }

      if (!_hijos.ContainsKey(nodo))
      {
        MessageBoxHelper.ShowError("Debe seleccionar un nodo raiz");
        return;
      }

      Permiso hijo = _hijos[nodo];

      try
      {
        _permisoBLL.Remover(_familia, hijo);

        treFamilia.Nodes.Remove(nodo);

        _hijos.Remove(nodo);

        EnlazarTreeView(_permisoBLL.Todos());
      }
      catch (Exception ex)
      {
        MessageBoxHelper.ShowError(ex.Message);
      }
    }

    private void btnCrear_Click(object sender, EventArgs e)
    {
      string input = Microsoft.VisualBasic.Interaction.InputBox("Nombre",
                       "Crear Familia",
                       "",
                       Width / 2,
                       Height / 2);

      if (string.IsNullOrWhiteSpace(input))
      {
        //MessageBoxHelper.ShowError("Debe ingresar un nombre");
        return;
      }

      Familia familia = new Familia 
      { 
        Nombre = input
      };

      try
      {
        _permisoBLL.Crear(familia);

        MessageBox.Show("Familia creada con exito");

        cboFamilias.Items.Add(familia);

        cboFamilias.SelectedItem = familia;

        EnlazarTreeView(_permisoBLL.Todos());
      }
      catch (Exception ex)
      {
        MessageBoxHelper.ShowError(ex.Message);
      }      
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      Familia familia = (Familia)cboFamilias.SelectedItem;

      if (familia == null)
      {
        MessageBoxHelper.ShowError("Debe seleccionar una familia");
        return;
      }

      try
      {
        _permisoBLL.Eliminar(familia);

        MessageBox.Show("La familia ha sido eliminada con exito");

        cboFamilias.Items.Remove(familia);

        cboFamilias.SelectedItem = null;

        EnlazarTreeView(_permisoBLL.Todos());
      }
      catch (Exception ex)
      {
        MessageBoxHelper.ShowError(ex.Message);
      }
    }
  }
}
