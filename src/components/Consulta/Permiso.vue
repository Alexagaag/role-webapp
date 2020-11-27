<template>
  <tr>
    <td>
      {{ Permiso.nombreEmpleado }}
    </td>
    <td>
      {{ Permiso.apellidosEmpleado }}
    </td>
    <td>
      {{ Permiso.fkTipoPermiso.descripcion }}
    </td>
    <td>
      {{ Permiso.fechaPermiso }}
    </td>
    <td>
      <b-button variant="danger" v-on:click="Delete">Eliminar</b-button>
      <b-button variant="primary" v-on:click="EdPer">Editar</b-button>
    </td>
  </tr>
</template>


<script>
import axios from "axios";
export default {
  props: {
    Permiso: { type: Object },
  },
  
  methods: {
    Delete() {
      axios
        .post("https://localhost:44398/Permisos/Delete", this.Permiso)
        .then(this.Refresh());
    },
    Refresh() {
      alert("Eliminado satisfactoriamente");
      this.$emit("onDelete");
    },
    EdPer() {
      this.$emit("onEdPer", this.Permiso);
    },
  },
};
</script>