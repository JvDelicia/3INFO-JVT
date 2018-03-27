package com.jvt.a3aetim.aplicativo01;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class IdadeActivity extends AppCompatActivity {
	EditText EdT_idade;
	Button Btn_verificar;
	TextView TxV_faixa;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_idade);

		EdT_idade = (EditText)findViewById(R.id.EdT_idade);
		Btn_verificar = (Button)findViewById(R.id.Btn_verificar);
		TxV_faixa = (TextView)findViewById(R.id.TxV_faixa);
	}

	// PAUSADO - EXERCÍCIO 2 DE JAVA
	public void verificar(View view) {
		Integer idade = Integer.parseInt(EdT_idade.getText().toString());
	}
}
