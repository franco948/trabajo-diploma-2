using ConsultorioDigital.BLL.Seguridad;
using ConsultorioDigital.Seguridad;
using ConsultorioDigital.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConsultorioDigital.UI.Formularios
{
  public partial class PermisosForm : Form
  {
    private IDictionary<TreeNode, Permiso> _permisos = new Dictionary<TreeNode, Permiso>();
    private IDictionary<TreeNode, Permiso> _permisosUsuario = null;
    private PermisoBLL _permisoBLL = new PermisoBLL();
    private UsuarioBLL _usuarioBLL = new UsuarioBLL();
    private Usuario _usuario = null;

    public PermisosForm()
    {
      InitializeComponent();

      cboUsuarios.DisplayMember = "Email";

      cboUsuarios.DataSource = null;
      cboUsuarios.DataSource = _usuarioBLL.Todos();

      foreach (Permiso permiso in _permisoBLL.Todos())
      {
        TreeNode node = new TreeNode(permiso.Nombre);

        _permisos.Add(node, permiso);

        trePermisos.Nodes.Add(node);

        AgregarRecursivo(permiso, node);
      }
    }

    private void AgregarRecursivo(Permiso permiso, TreeNode nodoPadre)
    {
      foreach (Permiso hijo in permiso.Hijos)
      {
        TreeNode nodoHijo = new TreeNode(hijo.Nombre);

        nodoPadre.Nodes.Add(nodoHijo);

        AgregarRecursivo(hijo, nodoHijo);
      }
    }

    private void cboUsuarios_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      trePermisosUsuario.Nodes.Clear();

      _usuario = (Usuario)cboUsuarios.SelectedItem;
           
      _usuario.Permisos = _usuarioBLL.Permisos(_usuario);

      _permisosUsuario = new Dictionary<TreeNode, Permiso>();

      foreach (Permiso permiso in _usuario.Permisos)
      {
        TreeNode node = new TreeNode(permiso.Nombre);

        _permisosUsuario.Add(node, permiso);

        trePermisosUsuario.Nodes.Add(node);

        AgregarRecursivo(permiso, node);
      }
    }

    private void btnAgregar_Click(object sender, System.EventArgs e)
    {
      TreeNode node = trePermisos.SelectedNode;

      if (_usuario == null)
      {
        MessageBoxHelper.ShowError("Tiene que seleccionar un usuario");
        return;
      }

      if (!_permisos.ContainsKey(node))
      {
        MessageBoxHelper.ShowError("No se pueden agregar nodos hijos. Seleccione un nodo padre");
        return;
      }

      Permiso permiso = _permisos[node];

      try
      {
        _usuarioBLL.Habilitar(_usuario, permiso);

        _usuario.Agregar(permiso);

        node = new TreeNode(permiso.Nombre);

        _permisosUsuario.Add(node, permiso);

        trePermisosUsuario.Nodes.Add(node);

        AgregarRecursivo(permiso, node);
      }
      catch (Exception ex)
      {
        MessageBoxHelper.ShowError(ex.Message);
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      TreeNode nodo = trePermisosUsuario.SelectedNode;

      // TODO es necesario ? por lo que estuve viendo siempre 
      // hay un permiso seleccionado al menos que el usuario no tenga permisos
      if (nodo == null)
      {
        MessageBoxHelper.ShowError("Tiene que seleccionar un permiso");
        return;
      }

      if (!_permisosUsuario.ContainsKey(nodo))
      {
        MessageBoxHelper.ShowError("No se pueden agregar nodos hijos. Seleccione un nodo padre");
        return;
      }

      Usuario usuario = (Usuario)cboUsuarios.SelectedItem;
      Permiso permiso = _permisosUsuario[nodo];

      try
      {
        _usuarioBLL.Deshabilitar(usuario, permiso);

        trePermisosUsuario.Nodes.Remove(nodo);

        usuario.Remover(permiso);

        _permisosUsuario.Remove(nodo);
      }
      catch (Exception ex)
      {
        MessageBoxHelper.ShowError(ex.Message);
      }
    }
  }
}
