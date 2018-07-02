<template>
  <q-page>
    <q-tabs style="float:left;" color="#FFFFFF" text-color="block" position="top" align="left">
      <q-tab slot="title" name="tab-0">
        <img style="width:40px" src="../statics/logo.png" />
      </q-tab>
    </q-tabs>
    <q-tabs style="float:right;" color="#FFFFFF" text-color="block" position="top" align="justify">
      <q-route-tab to="/login" slot="title" icon="person_pin_circle" name="tab-1">
        <div class="q-lable">登录</div>
      </q-route-tab>
      <q-route-tab to="/reg" slot="title" icon="face" name="tab-2">
        <div class="q-lable">注册</div>
      </q-route-tab>
    </q-tabs>
    <!--轮播图-->
    <q-carousel class="text-white"
                or
                infinite
                autoplay
                arrows
                style="height:300px;width:100%"
                color="white">
      <q-carousel-slide img-src="statics/1.jpg">
        <div class="q-display-3"></div>
      </q-carousel-slide>
      <q-carousel-slide img-src="statics/2.jpg">
        <div class="q-display-3"></div>
      </q-carousel-slide>
      <q-carousel-slide img-src="statics/3.jpg">
        <div class="q-display-3"></div>
      </q-carousel-slide>
    </q-carousel>
    <!--卡片-->
    <q-card>
      <q-card-title>
        更多精彩
      </q-card-title>
      <q-card-separator />
      <q-card-main>
        <img style="width:100%" src="../statics/1.jpg" />
      </q-card-main>
      <q-card-main>
        <img style="width:100%" src="../statics/1.jpg" />
      </q-card-main>
      <q-card-main>
        <img style="width:100%" src="../statics/1.jpg" />
      </q-card-main>
      <q-card-main>
        <img style="width:100%" src="../statics/1.jpg" />
      </q-card-main>
      <q-card-main>
        <img style="width:100%" src="../statics/1.jpg" />
      </q-card-main>
    </q-card>
    <q-card>
      <q-card-title style="text-align:center;color:grey">
        版权所有·资源屋 V1.0.0
      </q-card-title>
      <q-card-separator />
    </q-card>
  </q-page>
</template>
<style>
  .q-lable {
    color: grey
  }
</style>
<script>
  import { QTabs, QTab, QBtn, QTabPane } from 'quasar'
  export default {
    name: 'PageIndex',
    components: {
      QTabs,
      QTab,
      QBtn,
      QTabPane
    },
    data() {
      return {
        // 初始化为默认选择第二个选项卡
        selectedTab: 'tab-2',
      }
    },
    methods: {
      selectThirdTab() {
        // 我们选择'name'设置为'tab-3'的第三个标签
        this.selectedTab = 'tab-3'
      }
    }
  }
</script>
