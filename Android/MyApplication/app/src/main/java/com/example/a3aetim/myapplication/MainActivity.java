package com.example.a3aetim.myapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void abrirCadastro(View view){
        Intent intent = new Intent(this, CadastrarActivity.class );
        startActivity(intent);
    }
    public void abrirConsultar(View view){
        Intent intent = new Intent(this, LIstarActivity.class);
        startActivity(intent);
    }
    public void Sair(View view) {
        System.exit(0);
    };
}
