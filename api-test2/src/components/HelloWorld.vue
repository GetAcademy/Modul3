<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <h2>People</h2>
    <table>
      <tr>
        <td colspan="6">
          <input class="stretch" v-model="NameSearch" placeholder="Search by Name" type="text" />
        </td>
        <td colspan="2">
          <button class="stretch" @click="GetUsers(Myself,`/name/${NameSearch}`)" title="Search">Name Search</button>
        </td>
      </tr>
      <tr>
        <td colspan="6">
          <input class="stretch" v-model="Search" placeholder="Free Search" type="text" />
        </td>
        <td colspan="2">
          <button class="stretch" @click="GetUsers(Myself,`/search/${Search}`)" title="Free Search">Free Search</button>
        </td>
      </tr>
      <tr>
        <th>ID</th>
        <th>Name</th>
        <th>Birth Year</th>
        <th>Age</th>
        <th>Mother</th>
        <th>Father</th>
        <th>Update</th>
        <th>Delete</th>
      </tr>
      <tr v-for="folk in people" v-bind:key="folk.id">
        <td>
          <span placeholder="ID">{{folk.id}}</span>
        </td>
        <td>
          <input v-model="folk.name" placeholder="Name" type="text" />
        </td>
        <td>
          <input v-model="folk.birthYear" placeholder="BirthYear" type="number" />
        </td>
        <td>
          <input v-model="folk.age" placeholder="Age" type="number" />
        </td>
        <td>
          <input v-model="folk.mother" placeholder="Mother" type="text" />
        </td>
        <td>
          <input v-model="folk.father" placeholder="Father" type="text" />
        </td>
        <td>
          <button title="Update" @click="UpdateUser(folk)">Update</button>
        </td>
        <td>
          <button title="Delete" @click="DeleteUser(folk.id)">Delete</button>
        </td>
      </tr>
      <tr>
        <th colspan="8">
          Add new Person to the table
        </th>
      </tr>
      <tr>
        <td>
            ID
        </td>
        <td>
          <input v-model="Name" placeholder="Name" type="text" />
        </td>
        <td>
          <input v-model="BirthYear" placeholder="BirthYear" type="number" />
        </td>
        <td>
          <input v-model="Age" placeholder="Age" type="number" />
        </td>
        <td>
          <input v-model="Mother" placeholder="Mother" type="text" />
        </td>
        <td>
          <input v-model="Father" placeholder="Father" type="text" />
        </td>
        <td>
          <button title="Submit" @click="ConstructUser">Submit</button>
        </td>
        <td>
          <button title="Empty the Input Fields" @click="EmptyFields">Erase</button>
        </td>
      </tr>
    </table>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "HelloWorld",
  data() {
    return {
      msg: "Welcome to the user Database Client",
      people: [],
      Name: "",
      BirthYear: null,
      Age: null,
      Mother: "",
      Father: "",

      ID: null,

      NameSearch: null,
      Search: null,
      Myself: this
    };
  },
  methods: {
    AddUser: async function(person) {
      var resp;
      resp = await axios.post("/api/People", person);
      console.log(Response.prototype);
      this.EmptyFields();
      this.GetUsers(this);
    },
    ConstructUser: function() {
      const me = this;
      var object = {
        Name: me.Name,
        BirthYear: me.BirthYear,
        Age: me.Age,
        Mother: me.Mother,
        Father: me.Father
      };
      me.AddUser(object);
    },
    DeleteUser: async function(ID) {
      await axios.delete(`/api/People/${ID}`);
      console.log(Response.prototype);
      this.GetUsers(this);
    },
    UpdateUser: async function(object) {
      await axios.put(`/api/People/${object.id}`, object);
      console.log(Response.prototype);
      console.log(`updated user with this data: ${object}`);
      this.GetUsers(this);
    },
    GetUsers: async (me, name = "") => {
      try {
        const response = await axios.get(`/api/People${name}`);
        console.log(response.data);
        me.people = [];
        await me.people.push(...response.data);
      } catch (error) {
        console.error(error);
      }
    },
    
    EmptyFields: function(){
      this.Name = null;
      this.BirthYear = null;
      this.Age = null;
      this.Mother = null;
      this.Father = null;
    }
  },
  created: async function() {
    const self = this;
    this.GetUsers(self);
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1,
h2 {
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
button {
  width: 5vw;
  height: 2.5vh;
}
table,
tr,
th,
td {
  margin-left:auto;
  margin-right:auto;
  border: 1px solid black;
}
.stretch{
  width: 99%;
  height: 99%;
}
</style>
