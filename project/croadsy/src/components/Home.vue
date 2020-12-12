<template lang="pug">
  .content-wrapper
    section
      .container
        h1.ui-title-1 Найди активности в твоем городе!
    section
      .container
        h2.ui-title-4 Город
          select.select_box(v-model='post.city' name='City')
            option(hidden='') Example Placeholder
            option(
              v-for="city in CityList"
            ) {{ city }}
        form
            h2.ui-title-4  Интересы
            div
              input#int1(type='checkbox' name='int' value='Развлечения' v-model='post.tags')
              label(for='int1') Развлечения
              input#int2(type='checkbox' name='int' value='Архитектура' v-model='post.tags')
              label(for='int2') Архитектура
              input#int3(type='checkbox' name='int' value='Арт' v-model='post.tags')
              label(for='int3') Арт
              input#int4(type='checkbox' name='int' value='Еда' v-model='post.tags')
              label(for='int4') Еда
              input#int5(type='checkbox' name='int' value='Спорт' v-model='post.tags')
              label(for='int5') Спорт
              input#int6(type='checkbox' name='int' value='Природа' v-model='post.tags')
              label(for='int6') Природа
              input#int7(type='checkbox' name='int' value='Прогулки' v-model='post.tags')
              label(for='int7') Прогулки
            h2.ui-title-4 Для кого
            div
              input#age1(type='checkbox' name='age' value='0' v-model='post.tags')
              label(for='age1') 0+
              input#age2(type='checkbox' name='age' value='6' v-model='post.tags')
              label(for='age2') 6+
              input#age3(type='checkbox' name='age' value='12' v-model='post.tags')
              label(for='age3') 12+
              input#age4(type='checkbox' name='age' value='Дети' v-model='post.tags')
              label(for='age4') Дети
            h2.ui-title-4  Мероприятия
            div
              input#event1(type='checkbox' name='event' value='Музеи' v-model='post.tags')
              label(for='event1') Музеи
              input#event2(type='checkbox' name='event' value='Экскурсии' v-model='post.tags')
              label(for='event2') Экскурсии
              input#event3(type='checkbox' name='event' value='Мастер-классы' v-model='post.tags')
              label(for='event3') Мастер-классы
              input#event4(type='checkbox' name='event' value='Спектакли' v-model='post.tags')
              label(for='event4') Спектакли
              input#event5(type='checkbox' name='event' value='Концерты' v-model='post.tags')
              label(for='event5') Концерты
    section
      .container
        .row.grid-center
          .col-xs-3
            .grid-example-block
              span col-xs-3
          .col-xs-3
            .grid-example-block
              span col-xs-3
          .col-xs-3
            .grid-example-block
              span col-xs-3
          .col-xs-3
            .grid-example-block
              span col-xs-3
</template>

<script>
export default {
  data () {
    return {
      post: {
        tags: [],
        city: ''
      },
      CityList: ['Все города', 'Москва', 'Санкт-Петербург']
    }
  }
}

</script>

<style lang="stylus" scoped>
@import url('https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100;0,200;0,300;0,400;0,600;0,700;0,800;0,900;1,500&display=swap')

body
  font-family 'Montserrat', sans-serif

form
  div
    display flex
    flex-wrap wrap
    align-items center
    margin-bottom 2em

@media screen and (max-width:770px) {
  h2.ui-title-4 {
    font-size: 16px;
    margin-bottom 10px;
    }
  label {
    font-size: 14px;
    margin-right 10px;
    }
  body select {
    font-size: 14px;
    margin-top 10 px;
    }
}

@media screen and (min-width:770px) {
  h2.ui-title-4 {
    font-size: 18px;
    margin-bottom 20px
  }
  label {
    font-size: 16px;
    margin-right 20px;
  }
  body select {
    font-size: 16px;
    margin-top 20 px;
  }
}

input[type="checkbox"]
  -webkit-appearance none
  height 30px
  & + label
    background #eee
    padding 7px 15px
    border-radius 50px
    border 2px solid transparent
    transition all .3s ease
    &::before
      display inline-block
      border 1px solid #888
      width 20px
      height 20px
      text-align center
      margin-right 5px
      border-radius 4px
      transition all .3s ease

input[type="checkbox"]:checked
  & + label
    background #0055cc
    color #fff
    &::before
      border-color #fff
      color #fff
  &:hover
    & + label
      &::before
        color #0055cc
        background #fff

input[type="checkbox"]:not(:checked):hover
  & + label
    border 1px solid #0055cc
    &::before
      background #0055cc
      color #fff
      border-color #0055cc

select {
    margin-left -5 px
    display: block;
    padding: 10px 70px 10px 13px !important;
    max-width: 40%;
    height: auto !important;
    border: 1px solid #dedede;
    border-radius: 30px;
    background-color: #fff;
    background: url("https://i.ibb.co/b7xjLrB/selectbox-arrow.png") right center no-repeat;
    color: #444444;
    font-family 'Montserrat', sans-serif
    line-height: 30px !important;
    appearance: none;
   -webkit-appearance: none;
    -moz-appearance: none;
}

select
  &:hover
    border 1px solid #0055cc
    border-radius 30px
    transition all .3s ease
  option
    padding 0 4px
    font-size 16px
  &::-ms-expand
    display none
  &:disabled
    &::-ms-expand
      background #f60
</style>
