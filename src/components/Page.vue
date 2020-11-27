<template>
  <div id="page">
    <div id="Header">
      <b-navbar type="dark" variant="primary">
        <b-navbar-brand href="#"
          >Sistema de Registro de Permisos</b-navbar-brand
        >
        <b-navbar-nav>
          <b-nav-item v-on:click="FShowConsulta()">Consulta</b-nav-item>
          <b-nav-item v-on:click="FShowAdd()">Registro</b-nav-item>
        </b-navbar-nav>
      </b-navbar>
    </div>
    <BodyConsulta
      style="margin-left: 15%"
      v-if="ShowConsulta"
      :getPermisos="getPermisos()"
      v-on:EditarPermiso="EditPermiso"
      :Permisos="Permisos"
    ></BodyConsulta>
    <BodyAdd
      v-if="ShowAdd"
      :Permiso="Permisoform"
      style="margin-left: 30%"
      :options="options"
    ></BodyAdd>
    <div class="footer" id="Footer">
      <b-navbar type="dark" variant="primary">
        <h1 style="margin-left: 35%">Esta es una evaluacion</h1>
      </b-navbar>
    </div>
  </div>
</template>


<script>
import axios from "axios";
import BodyConsulta from "./Consulta/BodyConsulta";
import BodyAdd from "./Add/BodyAdd";

export default {
  name: "Page",
  props: {
    ShowConsulta: Boolean,
    ShowAdd: Boolean,
  },
  data() {
    return {
      Permisos: [],
      Permisoform: {
        id: 0,
        nombreEmpleado: "",
        apellidosEmpleado: "",
        tipoPermiso: null,
        fechaPermiso: null,
      },
      options: [],
    };
  },

  components: {
    BodyConsulta,
    BodyAdd,
  },
  methods: {
    getPermisos() {
      axios.get("https://localhost:44398/Permisos/GetAll").then((response) => {
        this.Permisos = response.data;
      });
    },
    getOptions() {
      axios
        .get("https://localhost:44398/Permisos/GetAllTipoPermiso")
        .then((response) => {
          this.options = response.data;
        });
    },
    FShowConsulta() {
      this.ShowConsulta = true;
      this.ShowAdd = false;
      this.getPermisos();
    },
    FShowAdd() {
      this.Permisoform.id = 0;
      this.Permisoform.nombreEmpleado = "";
      this.Permisoform.apellidosEmpleado = "";
      this.Permisoform.tipoPermiso = null;
      this.Permisoform.fechaPermiso = null;
      this.ShowConsulta = false;
      this.ShowAdd = true;
      this.getOptions();
    },
    EditPermiso(Per) {
      console.log(Per.fechaPermiso);
      this.Permisoform.nombreEmpleado = Per.nombreEmpleado;
      this.Permisoform.apellidosEmpleado = Per.apellidosEmpleado;
      this.Permisoform.tipoPermiso = Per.tipoPermiso;
      this.Permisoform.fechaPermiso = Per.fechaPermiso;
      this.Permisoform.id = Per.id;
      this.ShowConsulta = false;
      this.ShowAdd = true;
    },
  },
  created: function () {
    this.getOptions();
  },
};
</script>
<style>
.footer {
  position: fixed;
  left: 0;
  bottom: 0;
  width: 100%;
}
</style>