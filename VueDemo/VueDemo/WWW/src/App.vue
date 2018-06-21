<template>
    <div id="app">
        <div class="head" :style="{'height':headH,'lineHeight':headH,'backgroundColor':'#2D2D30',}">
            <h1>资源屋</h1>
        </div>
        <div class="content">
            <router-view></router-view>
        </div>
        <div class="foot">

        </div>
    </div>
</template>
<script>
    export default {
        name: 'app',
        data() {
            return {
                headH: '5rem',
            };
        },
        mounted() { },
        methods: {
            layout() {

            }
        }
    }
</script>
<style>
    html {
        font-family: 'Microsoft YaHei', Helvetica, Arial, sans-serif;
        font-size: 12px;
    }

    #app {
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        color: #2c3e50;
        width: 100%
        /* margin-top: 60px; */
    }

    .head {
        margin: auto auto auto auto;
        text-align: center;
        color:white
    }
</style>
