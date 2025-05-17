 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44392/',
  redirectUri: baseUrl,
  clientId: 'MoftiSolution_App',
  responseType: 'code',
  scope: 'offline_access MoftiSolution',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'MoftiSolution',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44392',
      rootNamespace: 'MoftiSolution',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
