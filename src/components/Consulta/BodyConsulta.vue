<template>
  <table style="width: 70%" class="ui celled table">
    <thead>
      <th>Nombre del Empleado</th>
      <th>Apellidos del Empleado</th>
      <th>Tipo de Permiso</th>
      <th>Fecha del Permiso</th>
      <th>Acciones</th>
    </thead>
    <tbody>
      <Permiso
        :onDelete="getPermisos"
        v-for="per in Permisos"
        :key="per.Id"
        :Permiso="per"
        v-on:onEdPer="Edit"
      ></Permiso>
    </tbody>
  </table>
</template>

<script>
import Permiso from "./Permiso.vue";

export default {
  name: "BodyConsulta",
  props: {
    Permisos: {type: Array}
  },
  components: {
    Permiso,
  },
  methods: {
      getPermisos(){
          this.$emit("getPermisos");
      },
    Edit(params){
        this.$emit("EditarPermiso", params)
    }
  },
};
</script>