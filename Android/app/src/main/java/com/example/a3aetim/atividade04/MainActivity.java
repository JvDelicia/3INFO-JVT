package com.example.a3aetim.atividade04;

import android.content.ContentValues;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //as coisas da activity

        helper = new DatabaseHelper(this);
    }

    public void Salvar(View view) {
        SQLiteDatabase db = helper.getWriteableDatabase();
        ContentValues values = new ContentValues();
        values.put("atributo", valor);
        long result = db.insert("banco", null, values);
        if (result != -1) {
            Toast.makeText(this, "Registro salvo", Toast.LENGTH_SHORT).show();
        } else {
            Toast.makeText(this, "Erro ao salvar", Toast.LENGTH_SHORT).show();
        }
    }

    @Override
    protected void onDestroy() {
        helper.close();
        super.onDestroy();
    }
}
