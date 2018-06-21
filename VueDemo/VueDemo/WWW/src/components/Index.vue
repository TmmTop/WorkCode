<template>
    <div class="index">
        <Icon type="ios-bolt-outline" size="150"></Icon>
        <!-- <img src="../assets/logo.png"> -->
        <h1>Parcel-VUE</h1>
        <br />
        <h3>parcel-vue是全新的组件化构建开发模板，追求最零化的配置，支持vux/iview等组件框架，提供秒级开发与部署（已升级parcel至1.9.0版本!）</h3>
        <br />
        <Row type="flex" justify="space-around">
            <Col span="5">
            <Card>
                <div style="text-align:center">
                    <!-- <img src="../../images/logo.png"> -->
                    <!-- <router-link to="/layout/devup"> -->
                    <Icon type="ios-trash-outline" size="100"></Icon>
                    <!-- </router-link> -->
                    <h2>零配置</h2>
                    <h3>完全没有单独的构建配置文件</h3>
                </div>
            </Card>
            </Col>
            <Col span="5">
            <Card>
                <div style="text-align:center">
                    <!-- <img src="../../images/logo.png"> -->
                    <!-- <router-link to="/layout/devcli"> -->
                    <Icon type="hammer" size="100"></Icon>
                    <!-- </router-link> -->
                    <h2>秒级构建</h2>
                    <h3>iView工程初次构建时间5s左右</h3>
                </div>
            </Card>
            </Col>
            <Col span="5">
            <Card>
                <div style="text-align:center">
                    <!-- <img src="../../images/logo.png"> -->
                    <!-- <router-link to="/layout/devkoa"> -->
                    <Icon type="social-nodejs" size="100"></Icon>
                    <!-- </router-link> -->
                    <h2>毫秒级热部署</h2>
                    <h3>修改源码，响应时间通常1-10ms</h3>
                </div>
            </Card>
            </Col>
            <Col span="5">
            <Card>
                <div style="text-align:center" @click="showClick">
                    <!-- <img src="../../images/logo.png"> -->
                    <!-- <router-link to="/layout/devcomponents"> -->
                    <Icon type="play" size="100"></Icon>
                    <!-- </router-link> -->

                    <h2 v-if="showTip">快速开始</h2>
                    <h3>开始您的parcel-vue之旅</h3>
                </div>
            </Card>
            </Col>
        </Row>
    </div>
</template>
<script>
    export default {
        name: "index",
        mounted() { },
        data() {
            return {
                showTip: false
            };
        },
        methods: {
            showClick() {
                this.showTip = true;
            }
        }
    };
</script>
<style>

    li {
        display: inline-block;
        margin: 0 10px;
    }

    a {
        color: #42b983;
    }

    .index {
        text-align: center;
       
    }
</style>
