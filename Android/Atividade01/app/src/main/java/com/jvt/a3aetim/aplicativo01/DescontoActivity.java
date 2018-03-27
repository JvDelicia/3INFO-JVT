package com.jvt.a3aetim.aplicativo01;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class DescontoActivity extends AppCompatActivity {

	EditText EdT_valor;
	EditText EdT_numero;
	TextView TxV_resultado;

	Float n1;
	byte n2;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_desconto);

		EdT_valor = (EditText)findViewById(R.id.EdT_valor);
		EdT_numero = (EditText)findViewById(R.id.EdT_numero);
		TxV_resultado = (TextView)findViewById(R.id.TxV_resultado);
	}

	public void calcular(View view) {

		n1 = Float.parseFloat(EdT_valor.getText().toString());
		n2 = Byte.parseByte(EdT_numero.getText().toString());

		Double preco;

		switch(n2) {
			case 1:
				preco = n1 - (n1 * 0.05);
				TxV_resultado.setText(preco.toString());
				break;
			case 2:
				preco = n1 - (n1 * 0.1);
				TxV_resultado.setText(preco.toString());
				break;
			case 3:
				preco = n1 - (n1 * 0.2);
				TxV_resultado.setText(preco.toString());
				break;
			case 4:
				preco = n1 - (n1 * 0.5);
				TxV_resultado.setText(preco.toString());
				break;
			default:
				TxV_resultado.setText(n1.toString());
		}
	}
}
