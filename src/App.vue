<template>
  <div id="app">
    <Page :ShowAdd="true"
          :ShowConsulta="false"></Page>
  </div>
</template>

<script>
import Page from './components/Page'

export default {
  name: 'App',
  components: {
Page
  }
}
</script>

