(function () {

	$(function () {
		var $loginForm = $('#LoginForm');

		$loginForm.submit(function (e) {
			e.preventDefault();

			if (!$loginForm.valid()) {
				return;
			}

			abp.ui.setBusy(
				$('#LoginArea'),
				abp.ajax({
					contentType: 'application/json',
					type: 'POST',
					url: '/Account/Login',
					data: JSON.stringify({
						usernameOrEmailAddress: $("#usernameOrEmailAddress").val(),
						password: $("#password").val(),
						rememberMe: $('#remember_account').is(':checked'),
						returnUrl: "/Home/Index"
					})
				}).done(function (data) {
					abp.notify.success('success');
				})
			);
		});

		//$('a.social-login-link').click(function () {
		//    var $a = $(this);
		//    var $form = $a.closest('form');
		//    $form.find('input[name=provider]').val($a.attr('data-provider'));
		//    $form.submit();
		//});

		//$('input[name=returnUrlHash]').val(location.hash);

		$('#LoginForm input:first-child').focus();
	});

})();