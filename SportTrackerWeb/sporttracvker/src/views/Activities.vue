<template>
    <div class="background-container d-flex flex-column justify-content-center align-items-center min-vh-100">
      <div class="text-center">
        <h1>Seznam aktivit</h1>
  
        <div v-if="activities.length > 0">
          <table class="table table-dark table-striped table-hover">
            <thead>
              <tr>
                <th scope="col">Typ aktivity</th>
                <th scope="col">Vzdálenost (km)</th>
                <th scope="col">Datum a čas</th>
                <th scope="col">Poznámky</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="activity in activities" :key="activity.id">
                <td>{{ activity.activityType }}</td>
                <td>{{ activity.distance }}</td>
                <td>{{ new Date(activity.activityDate).toLocaleString() }}</td>
                <td>{{ activity.notes ? activity.notes : 'Žádné poznámky' }}</td>
              </tr>
            </tbody>
          </table>
        </div>
  
        <div v-else class="text-center">
          <p class="lead">Žádné aktivity k zobrazení.</p>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  import api from '@/api';
  
  export default {
    name: 'Activities',
    data() {
      return {
        activities: []
      };
    },
    created() {
      this.fetchActivities();
    },
    methods: {
      fetchActivities() {
        api.getActivities().then(response => {
          this.activities = response.data;
        });
      }
    }
  };
  </script>
  
  <style scoped>
  .background-container {
    background-image: url('@/assets/pexels-pixabay-163403.jpg'); /* Cesta k obrázku */
    background-size: cover;
    background-position: center;
    background-repeat: no-repeat;
    min-height: 100vh;
    padding: 20px;
  }
  
  h1 {
  font-size: 2.5rem;
  font-weight: bold;
  color: #ffffff;
  text-shadow: 2px 2px 5px rgba(0, 0, 0, 0.7); /* Zvýrazněný stín pro lepší čitelnost */
  margin-bottom: 20px;
}

.table {
  background-color: rgba(0, 0, 0, 0.3); /* Vyšší průhlednost pro pozadí tabulky */
  color: #ffffff;
  border-radius: 25px; /* Větší zaoblení rohů */
  overflow: hidden; /* Zajišťuje správné zobrazení zaoblených rohů */
  box-shadow: 0 6px 12px rgba(0, 0, 0, 0.3); /* Silnější stín pro větší vizuální efekt */
  max-width: 90%; /* Tabulka bude maximálně na 90% šířky stránky */
  margin: 0 auto; /* Vycentrování tabulky */
}

th, td {
  border-color: rgba(255, 255, 255, 0.2); /* Jemné ohraničení buněk */
  padding: 15px; /* Větší výplň pro lepší čitelnost */
}

.table-hover tbody tr:hover {
  background-color: rgba(255, 255, 255, 0.2); /* Zvýraznění řádku při hoveru */
}
  </style>
  