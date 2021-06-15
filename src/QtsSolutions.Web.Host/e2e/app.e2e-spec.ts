import { QtsSolutionsTemplatePage } from './app.po';

describe('QtsSolutions App', function() {
  let page: QtsSolutionsTemplatePage;

  beforeEach(() => {
    page = new QtsSolutionsTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
