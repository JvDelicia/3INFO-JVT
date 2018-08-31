package com.example.a3aetim.myapplication;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class DataBaseHelper extends SQLiteOpenHelper {
    private static final String BANCO_DADOS = "BdDados";
    public static final int VERSAO = 1;

    public DataBaseHelper(Context context){
        super(context,BANCO_DADOS,null,VERSAO);
    }

    @Override
    public void onCreate(SQLiteDatabase db){
        db.execSQL ("Create table Campeonato (_id INTEGER PRIMARY KEY AUTOINCREMENT, Premio MONEY, NomeCamp TEXT);");

        db.execSQL ("Create table Organizacao (_id INTEGER PRIMARY KEY AUTOINCREMENT,NomeTime TEXT, PaisTime TEXT,  FOREIGN KEY(Camp_Id) REFERENCES Campeonato(_id) ) ;");

        db.execSQL("Create table Player (_id INTEGER PRIMARY KEY AUTOINCREMENT, nomejog TEXT , Idade INTEGER, NickName TEXT, FOREIGN KEY(Org_Id) REFERENCES Organizacao(_id));");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldversion, int newversion ){}
}

