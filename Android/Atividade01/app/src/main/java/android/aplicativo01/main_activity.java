package android.aplicativo01;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import static android.provider.AlarmClock.EXTRA_MESSAGE;

public class main_activity extends AppCompatActivity {

	public final static String EXTRA_MESSAGE = ".MESSAGE";

	Button btn_age, btn_discont, btn_numbers, btn_passwords;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main_activity);
	}

	private void changeToAge(View view) {
		btn_age = (Button)findViewById(R.id.btn_age);
		Intent intent = new Intent(this, AgeActivity.class);
		String msg = "Faça uma classe que receba a idade de uma pessoa e retorne uma mensagem de acordo com a tabela\n" +
				"0 a 2 = bebê\n" +
				"3 a 11 = criança\n" +
				"12 a 19 = adolescente\n" +
				"20 a 30 = jovem\n" +
				"31 a 60 = adulto\n" +
				">60 = idoso";
		intent.putExtra(EXTRA_MESSAGE, msg);
		startActivity(intent);
	}

	private void changeToDiscount(View view) {
		btn_discont = (Button)findViewById(R.id.btn_discont);
		Intent intent = new Intent(this, DiscountActivity.class);
		String msg = "Faça uma classe que receba o valor de um produto e um códgo de desconto. O desconto deverá ser calculado de acordo com a tabela:\n" +
				"1 = 5%\n" +
				"2 = 10%\n" +
				"3 = 20%\n" +
				"4 = 50%";
		intent.putExtra(EXTRA_MESSAGE, msg);
		startActivity(intent);
	}

	private void changeToNumbers(View view) {
		btn_numbers = (Button)findViewById(R.id.btn_numbers);
		Intent intent = new Intent(this, NumbersActivity.class);
		String msg = "Crie uma classe que receba 4 valores quaisquer e mostre a média entre eles, o somatório e um resto da divisão do somatório com cada um dos valores.";
		intent.putExtra(EXTRA_MESSAGE, msg);
		startActivity(intent);
	}

	private void changeToPassword(View view) {
		btn_passwords = (Button)findViewById(R.id.btn_password);
		Intent intent = new Intent(this, PasswordActivity.class);
		String msg = "Faça uma classe que solicite uma senha, no caso senha java. Caso o user forneça a senha correta, apersentar a menssagem senha valida, caso contrario senha inválida. " +
				"Se o user fornecer a senha incorreta 3 vezes seguidas o programa deve apresentar a mensagem cartao cancelado.";
		intent.putExtra(EXTRA_MESSAGE, msg);
		startActivity(intent);
	}
}
