﻿using System;

class ServerRoot
{
    private static ServerRoot instance;
    public static ServerRoot Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ServerRoot();               
            }

            return instance;
        }
    }

    public void Init()
    {
        //DataBase

        //Network Layer
        NetworkService.Instance.Init();

        //Business Layer
        LoginSys.Instance.Init();
    }
}

