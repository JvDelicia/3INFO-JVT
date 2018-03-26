package com.example.a3aetim.soma;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

	// screen elements
	EditText num1, num2;
	Button soma, subtracao, multiplicacao, divisao;
	TextView resultado;

	// variables
	double n1, n2, res;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);

		num1 = (EditText)findViewById(R.id.num1);
		num2 = (EditText)findViewById(R.id.num2);

		soma = (Button)findViewById(R.id.soma);
		subtracao = (Button)findViewById(R.id.subtracao);
		multiplicacao = (Button)findViewById(R.id.multiplicacao);
		divisao = (Button)findViewById(R.id.divisao);

		resultado = (TextView)findViewById(R.id.reultado);
	}

	public void calcular(View view) {
		n1 = Double.parseDouble(num1.getText().toString());
		n2 = Double.parseDouble(num2.getText().toString());

		switch(view.getId()) {
			case R.id.soma: res = n1 + n2; break;
			case R.id.subtracao: res = n1 - n2; break;
			case R.id.multiplicacao: res = n1 * n2; break;
			case R.id.divisao: res = n1 / n2; break;
		}

		total.setText(Double.toString(res));
	}
}
