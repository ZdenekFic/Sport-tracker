<template>
    <div class="background-container d-flex justify-content-center align-items-center min-vh-100">
      <div class="text-center">
        <h1>Vítejte ve Sport Tracker</h1>
        <p class="lead">Sledujte své sportovní výkony, dosahujte cílů a zůstaňte motivovaní!</p>
        <router-link to="/activities" class="btn btn-primary btn-lg mt-4">Zobrazit aktivity</router-link>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    name: 'HomePage'
  };
  </script>
  
  <style scoped>
  .background-container {
    background-image: url('@/assets/pexels-pixabay-54326.jpg'); /* Změň cestu k obrázku */
    background-size: cover;
    background-position: center;
    background-repeat: no-repeat;
    min-height: 100vh;
  }
  
  h1 {
    font-size: 3rem;
    font-weight: bold;
    color: #ffffff;
    text-shadow: 2px 2px 5px rgba(0, 0, 0, 0.7); /* Zvýrazněný stín pro lepší čitelnost */
  }
  
  p.lead {
    font-size: 1.5rem;
    color: #ffffff;
    text-shadow: 1px 1px 3px rgba(0, 0, 0, 0.7); /* Jemný stín pro čitelnost */
  }
  
  .btn-primary {
    background-color: #007bff;
    border-color: #007bff;
    padding: 10px 20px;
    font-size: 1.2rem;
  }
  
  .btn-primary:hover {
    background-color: #0056b3;
    border-color: #004085;
  }
  </style>
  