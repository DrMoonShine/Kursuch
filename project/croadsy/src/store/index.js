import Vue from 'vue'
import Vuex from 'vuex'
import likes from './likes'

Vue.use(Vuex)

export default new Vuex.Store({
  modules: {
    likes
  }
})
