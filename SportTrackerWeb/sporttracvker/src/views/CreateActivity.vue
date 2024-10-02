<template>
    <div class="background-container d-flex justify-content-center align-items-center min-vh-100">
      <div class="card transparent-background">
        <div class="card-body">
          <h1 class="text-center mb-4">Přidat novou aktivitu</h1>
          <form @submit.prevent="addActivity">
            <div class="mb-3">
              <label for="activityType" class="form-label">Typ aktivity:</label>
              <input id="activityType" v-model="newActivity.activityType" type="text" class="form-control" placeholder="Zadejte typ aktivity" required />
            </div>
  
            <div class="mb-3">
              <label for="distance" class="form-label">Vzdálenost (km):</label>
              <input id="distance" v-model="newActivity.distance" type="number" step="0.01" class="form-control" placeholder="Zadejte vzdálenost v km" required />
            </div>
  
            <div class="mb-3">
              <label for="activityDate" class="form-label">Datum a čas:</label>
              <input id="activityDate" v-model="newActivity.activityDate" type="datetime-local" class="form-control" required />
            </div>
  
            <div class="mb-3">
              <label for="notes" class="form-label">Poznámky:</label>
              <textarea id="notes" v-model="newActivity.notes" class="form-control" placeholder="Poznámky"></textarea>
            </div>
  
            <button type="submit" class="btn btn-primary w-100">Přidat aktivitu</button>
          </form>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  import api from '@/api';
  
  export default {
    name: 'CreateActivity',
    data() {
      return {
        newActivity: {
          activityType: '',
          distance: 0,
          activityDate: '',
          notes: ''
        }
      };
    },
    methods: {
      addActivity() {
        if (this.newActivity.activityType && this.newActivity.distance > 0 && this.newActivity.activityDate) {
          api.postActivity(this.newActivity)
            .then(() => {
              alert("Aktivita úspěšně přidána!");
              this.newActivity = {
                activityType: '',
                distance: 0,
                activityDate: '',
                notes: ''
              };
            })
            .catch(error => {
              console.error("Chyba při přidávání aktivity:", error);
            });
        } else {
          alert("Vyplňte prosím všechna povinná pole.");
        }
      }
    }
  };
  </script>
  
  <style scoped>
  .background-container {
    background-image: url('@/assets/pexels-binyaminmellish-140039.jpg'); /* Cesta k tvému obrázku */
    background-size: cover;
    background-position: center;
    background-repeat: no-repeat;
    width: 100%;
    height: 100%;
  }
  
  .card.transparent-background {
    background-color: rgba(0, 0, 0, 0.6); /* Poloprůhledné černé pozadí */
    border-radius: 8px;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
    padding: 20px;
    max-width: 500px;
    width: 100%;
  }
  
  .card-body {
    padding: 20px;
  }
  
  h1 {
    font-size: 1.75rem;
    text-align: center;
    color: #fff; /* Bílé písmo pro lepší kontrast */
  }
  
  label {
    color: #fff; /* Bílé písmo pro lepší čitelnost */
  }
  </style>
  