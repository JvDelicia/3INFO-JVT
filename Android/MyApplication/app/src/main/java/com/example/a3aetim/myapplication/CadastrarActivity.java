package com.example.a3aetim.myapplication;

import android.content.ContentValues;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import org.w3c.dom.Text;

public class CadastrarActivity extends AppCompatActivity {
    EditText etNome, etIdade, etNick;
    DataBaseHelper helper;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cadastrar);
        etNome = (EditText) findViewById(R.id.etNome);
        etIdade = (EditText) findViewById(R.id.etIdade);
        etNick = (EditText) findViewById(R.id.etNick);
        helper = new DataBaseHelper(this);
    }
    public void CadastrarJogador(View view) {
        SQLiteDatabase db = helper.getWritableDatabase();
        ContentValues values = new ContentValues();
        String Name = etNome.getText().toString();
        Integer Idade = Integer.parseInt(etIdade.getText().toString());
        String Nick = etNick.getText().toString();
        values.put("Nomejog", Name);
        values.put("Idade", Idade);
        values.put("NickName", Nick);
        long result = db.insert("Player", null, values);
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
