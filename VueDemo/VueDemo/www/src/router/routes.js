
export default [
  {
    path: '/',
    component: () => import('layouts/default'),
    children: [
      { path: '/', component: () => import('pages/index') },
      { path: '/login', component: () => import('pages/login') },
      { path: '/reg', component: () => import('pages/reg') },
      { path: '/up', component: () => import('pages/reg') },
    ]
  },

  { // Always leave this as last one
    path: '*',
    component: () => import('pages/404')
  }
]
