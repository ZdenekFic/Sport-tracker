<template>
  <div>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
      <div class="container-fluid">
        <a class="navbar-brand custom-brand" href="#">Sport Tracker</a>
        <button
          class="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarNav"
          aria-controls="navbarNav"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
          <ul class="navbar-nav ms-auto">
            <li class="nav-item">
              <router-link class="nav-link" to="/">Home</router-link>
            </li>
            <li class="nav-item">
              <router-link class="nav-link" to="/activities">Aktivity</router-link>
            </li>
            <li class="nav-item">
              <router-link class="nav-link" to="/create-activity">Přidat aktivitu</router-link>
            </li>
          </ul>
        </div>
      </div>
    </nav>
    
    <router-view />
  </div>
</template>

<script>
export default {
  name: "App",
};
</script>


<style scoped>
/* Navigační panel s černým pozadím */
.navbar {
  background-color: #000000 !important; /* Čisté černé pozadí s důrazem */
  margin: 0;
  padding: 0;
  border-bottom: none !important; /* Zajištění odstranění jakéhokoli rámečku */
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1); /* Jemný stín */
}

.custom-brand {
  background-color: #ff0000 !important; /* Červené pozadí pro název */
  padding: 10px 20px;
  margin: 15px 15px;
  border-radius: 8px;
  color: #000000 !important;
  font-weight: bold;
  font-size: 1.8rem;
  text-transform: uppercase;
}



.navbar-nav .nav-link {
  color: #fff;
  font-size: 1.2rem;
  margin-left: 30px;
  transition: transform 0.3s ease, color 0.3s ease; /* Přidání plynulého přechodu pro transformaci a barvu */
}

.navbar-nav .nav-link:hover {
  transform: scale(1.4); /* Zvětšení textu o 20% při hoveru */
  color: #ff0000; /* Změna barvy textu při hoveru */
}


/* Obsah posunutý pod fixovanou navigací */
.content {
  margin-top: 80px;
}
</style>
