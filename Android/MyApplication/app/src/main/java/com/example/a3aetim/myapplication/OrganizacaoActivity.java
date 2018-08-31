package com.example.a3aetim.myapplication;

import android.content.ContentValues;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class OrganizacaoActivity extends AppCompatActivity {
    EditText etNomeOrg, etPaisOrg, etCodCamp;
    DataBaseHelper helper;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_organizacao);
        etNomeOrg = (EditText) findViewById(R.id.etNomeTime);
        etPaisOrg = (EditText) findViewById(R.id.etPaisdeOrigem);
        etCodCamp = (EditText) findViewById(R.id.etIdCamp);
        helper = new DataBaseHelper(this);
    }
    public void CadastrarOrganizacao(View view) {
        SQLiteDatabase db = helper.getWritableDatabase();
        ContentValues values = new ContentValues();
        String NomeOrg = etNomeOrg.getText().toString();
        String PaisOrg = etPaisOrg.getText().toString();
        String CodCamp = etCodCamp.getText().toString();
        values.put("NomeTime", NomeOrg);
        values.put("PaisTime", PaisOrg);
        values.put("Camp_Id", CodCamp);
        long result = db.insert("Organizacao", null, values);
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
